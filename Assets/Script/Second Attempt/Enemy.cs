using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //All bots in general
    public Machine machine;
    public GameObject game, lose;

    public Vector3 currentEulerAngles;
    public Quaternion currentRotation;
    public Transform Machine;
    public bool isRed, isYellow, isGreen, isBlue, isPurple;

    // Update is called once per frame
    void Update()
    {
        LookRotation();
        transform.position = Vector3.MoveTowards(this.transform.position, Machine.position, 10 * Time.deltaTime);
    }

    void LookRotation()
    {
        Vector3 relativePos = Machine.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            game.SetActive(false);
            gameObject.SetActive(false);
            lose.SetActive(true);
        }
    }
}
