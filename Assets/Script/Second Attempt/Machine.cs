using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine : MonoBehaviour
{
    public float radius; //Radar
    public Vector3 currentEulerAngles;
    public Quaternion currentRotation;

    //Machine
    public GameObject headCurrent, headRed, headYellow, headGreen, headBlue, headPurple;
    public bool bbulletRed, bbulletYellow, bbulletGreen, bbulletBlue, bbulletPurple;

    //Bots
    public Transform tRedBot, tYellowBot, tGreenBot, tBlueBot, tPurpleBot;
    public GameObject oRedBot, oYellowBot, oGreenBot, oBlueBot, oPurpleBot;
    public bool bRedBot, bYellowBot, bGreenBot, bBlueBot, bPurpleBot;

    //Color
    public string[] RandomColor;
    public string RandomPicker;

    // Start is called before the first frame update
    void Start()
    {
        oRedBot.SetActive(true); 
        oYellowBot.SetActive(false);
        oGreenBot.SetActive(false);
        oBlueBot.SetActive(false);
        oPurpleBot.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        RedBot();
        GreenBot();
        YellowBot();
        BlueBot();
        PurpleBot();

        switch (RandomPicker)
        {
            case "Red":
                RedColor();
                break;
            case "Yellow":
                YellowColor();
                break;
            case "Green":
                GreenColor();
                break;
            case "Blue":
                BlueColor();
                break;
            case "Purple":
                PurpleColor();
                break;
        }
    }

    //Color Changer
    private void OnMouseDown()
    {
        RandomPicker = RandomColor[Random.Range(0, RandomColor.Length)];
    }

    //Trigger
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    //Coloring
    void RedColor()
    {
        //Head
        headCurrent.SetActive(false);
        headRed.SetActive(true);
        headYellow.SetActive(false);
        headGreen.SetActive(false);
        headBlue.SetActive(false);
        headPurple.SetActive(false);

        //ForTheBullet
        bbulletRed = true;
        bbulletYellow = false;
        bbulletGreen = false;
        bbulletBlue = false;
        bbulletPurple = false;
    }

    void YellowColor()
    {
        //Head
        headCurrent.SetActive(false);
        headRed.SetActive(false);
        headYellow.SetActive(true);
        headGreen.SetActive(false);
        headBlue.SetActive(false);
        headPurple.SetActive(false);

        //ForTheBullet
        bbulletRed = false;
        bbulletYellow = true;
        bbulletGreen = false;
        bbulletBlue = false;
        bbulletPurple = false;
    }

    void GreenColor()
    {
        //Head
        headCurrent.SetActive(false);
        headRed.SetActive(false);
        headYellow.SetActive(false);
        headGreen.SetActive(true);
        headBlue.SetActive(false);
        headPurple.SetActive(false);

        //ForTheBullet
        bbulletRed = false;
        bbulletYellow = false;
        bbulletGreen = true;
        bbulletBlue = false;
        bbulletPurple = false;
    }

    void BlueColor()
    {
        //Head
        headCurrent.SetActive(false);
        headRed.SetActive(false);
        headYellow.SetActive(false);
        headGreen.SetActive(false);
        headBlue.SetActive(true);
        headPurple.SetActive(false);

        //ForTheBullet
        bbulletRed = false;
        bbulletYellow = false;
        bbulletGreen = false;
        bbulletBlue = true;
        bbulletPurple = false;
    }
    void PurpleColor()
    {
        //Head
        headCurrent.SetActive(false);
        headRed.SetActive(false);
        headYellow.SetActive(false);
        headGreen.SetActive(false);
        headBlue.SetActive(false);
        headPurple.SetActive(true);

        //ForTheBullet
        bbulletRed = false;
        bbulletYellow = false;
        bbulletGreen = false;
        bbulletBlue = false;
        bbulletPurple = true;
    }

    //Looking/Aiming at an enemy
    void RedBot()
    {
        float distR = Vector3.Distance(transform.position, tRedBot.position);
        if (distR <= radius)
        {
            Debug.Log("Red enemy nearby!");
            LookRotationRed();
        }
    }
    void YellowBot()
    {
        float distY = Vector3.Distance(transform.position, tYellowBot.position);
        if (distY <= radius)
        {
            Debug.Log("Yellow enemy nearby!");
            LookRotationYellow();
        }
    }
    void GreenBot()
    {
        float distG = Vector3.Distance(transform.position, tGreenBot.position);
        if (distG <= radius)
        {
            Debug.Log("Green enemy nearby!");
            LookRotationGreen();
        }
    }
    void BlueBot()
    {
        float distB = Vector3.Distance(transform.position, tBlueBot.position);
        if (distB <= radius)
        {
            Debug.Log("Blue enemy nearby!");
            LookRotationBlue();
        }
    }
    void PurpleBot()
    {
        float distP = Vector3.Distance(transform.position, tPurpleBot.position);
        if (distP <= radius)
        {
            Debug.Log("Purple enemy nearby!");
            LookRotationPurple();
        }
    }

    void LookRotationRed()
    {
        Vector3 relativePos = tRedBot.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }
    void LookRotationYellow()
    {
        Vector3 relativePos = tYellowBot.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }
    void LookRotationGreen()
    {
        Vector3 relativePos = tGreenBot.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }
    void LookRotationBlue()
    {
        Vector3 relativePos = tBlueBot.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }
    void LookRotationPurple()
    {
        Vector3 relativePos = tPurpleBot.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }
}
