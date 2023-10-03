using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : MonoBehaviour
{
    //First Bot
    public GameObject Green;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RedBullet")
        {
            Destroy(other.gameObject);
            gameObject.SetActive(false);
            Green.SetActive(true);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}
