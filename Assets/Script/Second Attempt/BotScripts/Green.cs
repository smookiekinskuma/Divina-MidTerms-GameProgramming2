using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green : MonoBehaviour
{
    //Second Bot
    public GameObject Yellow;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GreenBullet")
        {
            Destroy(other.gameObject);
            gameObject.SetActive(false);
            Yellow.SetActive(true);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}
