using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Yellow : MonoBehaviour
{
    //Third Bot
    public GameObject Blue;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "YellowBullet")
        {
            Destroy(other.gameObject);
            gameObject.SetActive(false);
            Blue.SetActive(true);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}
