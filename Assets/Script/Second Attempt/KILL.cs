using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KILL : MonoBehaviour
{
    //This is a sample script so that the bots work properly.
    public Machine Machine;
    public GameObject game, win;
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
        if (other.gameObject.tag == "Red" && Machine.bbulletRed == true)
        {
            RedBot.SetActive(false);
            GreenBot.SetActive(true);
        } //else ();

        if (other.gameObject.tag == "Green" && Machine.bbulletGreen == true)
        {
            GreenBot.SetActive(false);
            YellowBot.SetActive(true);
        }

        if (other.gameObject.tag == "Yellow" && Machine.bbulletYellow == true)
        {
            YellowBot.SetActive(false);
            BlueBot.SetActive(true);
        }

        if (other.gameObject.tag == "Blue" && Machine.bbulletBlue == true)
        {
            BlueBot.SetActive(false);
            PurpleBot.SetActive(true);
        }

        if (other.gameObject.tag == "Purple" && Machine.bbulletPurple == true)
        {
            PurpleBot.SetActive(false);
            game.SetActive(false);
            win.SetActive(true);
        }
    }
}
