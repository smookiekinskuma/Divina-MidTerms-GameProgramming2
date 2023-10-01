using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KILL : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject RedBot, GreenBot, YellowBot, BlueBot, PurpleBot;

    // Start is called before the first frame update
    void Start()
    {
        RedBot.SetActive(true);
        YellowBot.SetActive(false);
        GreenBot.SetActive(false);
        BlueBot.SetActive(false);
        PurpleBot.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Red") //&& BoomBoomPow.Instance.redon == true)
        {
            RedBot.SetActive(false);
            GreenBot.SetActive(true);
        }

        if (other.gameObject.tag == "Green") //&& BoomBoomPow.Instance.greenon == true)
        {
            GreenBot.SetActive(false);
            YellowBot.SetActive(true);
        }

        if (other.gameObject.tag == "Yellow") //&& BoomBoomPow.Instance.yellowon == true)
        {
            YellowBot.SetActive(false);
            BlueBot.SetActive(true);
        }

        if (other.gameObject.tag == "Blue") //&& BoomBoomPow.Instance.blueon == true)
        {
            BlueBot.SetActive(false);
            PurpleBot.SetActive(true);
        }

        if (other.gameObject.tag == "Purple") //&& BoomBoomPow.Instance.purpleon == true)
        {
            PurpleBot.SetActive(false);
        }
    }
}
