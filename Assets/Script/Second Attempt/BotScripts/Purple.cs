using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Purple : MonoBehaviour
{
    //Last Bot
    public GameObject game, win;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PurpleBullet")
        {
            Destroy(other.gameObject);
            game.SetActive(false);
            win.SetActive(true);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}
