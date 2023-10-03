using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue : MonoBehaviour
{
    //Fourth Bot
    public GameObject Purple;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BlueBullet")
        {
            Destroy(other.gameObject);
            gameObject.SetActive(false);
            Purple.SetActive(true);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}
