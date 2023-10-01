using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BoomBoomPow : MonoBehaviour
{
    //Will This Work?
    public static BoomBoomPow Instance { get; private set; }

    float x, y, z;
    public Vector3 currentEulerAngles;
    public Quaternion currentRotation;

    //Base
    public GameObject Base, Text;

    //Bots
    public Transform RedBot, GreenBot, YellowBot, BlueBot, PurpleBot;

    //Bullets
    public Transform Bullet;
    public GameObject currentBullet, Redbullet, Greenbullet, Yellowbullet, Bluebullet, Purplebullet;
    public bool redon, yellowon, greenon, blueon, purpleon;

    //Head
    public GameObject currentHead, RedHead, GreenHead, YellowHead, BlueHead, PurpleHead;

    //Radar
    public float radius;

    //loop. help.
    public string[] RandomColor;
    public string RandomPicker;

    // Start is called before the first frame update
    void Start()
    {
        Base.SetActive(true);
        Text.SetActive(false);
        //Bullet
        currentBullet.SetActive(true);
        Redbullet.SetActive(false);
        Greenbullet.SetActive(false);
        Yellowbullet.SetActive(false);
        Bluebullet.SetActive(false);
        Purplebullet.SetActive(false);
        //Head
        currentHead.SetActive(true);
        RedHead.SetActive(false);
        GreenHead.SetActive(false);
        YellowHead.SetActive(false);
        BlueHead.SetActive(false);
        PurpleHead.SetActive(false);
        //For The Bullet
        redon = false;
        yellowon = false;
        greenon = false;
        blueon = false;
        purpleon = false;
    }

    //changing colors
    private void OnMouseDown()
    {
        RandomPicker = RandomColor[Random.Range(0, RandomColor.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        //Color. Like in art, i suffer when coloring.
        switch (RandomPicker)
        {
            case "Red":
                //Bullet
                currentBullet.SetActive(false);
                Redbullet.SetActive(true);
                Greenbullet.SetActive(false);
                Yellowbullet.SetActive(false);
                Bluebullet.SetActive(false);
                Purplebullet.SetActive(false);
                //Head
                currentHead.SetActive(false);
                RedHead.SetActive(true);
                GreenHead.SetActive(false);
                YellowHead.SetActive(false);
                BlueHead.SetActive(false);
                PurpleHead.SetActive(false);
                //For the bullet
                redon = true;
                yellowon = false;
                greenon = false;
                blueon = false;
                purpleon = false;
                break;
            case "Yellow":
                //Bullet
                currentBullet.SetActive(false);
                Redbullet.SetActive(false);
                Greenbullet.SetActive(false);
                Yellowbullet.SetActive(true);
                Bluebullet.SetActive(false);
                Purplebullet.SetActive(false);
                //Head
                currentHead.SetActive(false);
                RedHead.SetActive(false);
                GreenHead.SetActive(false);
                YellowHead.SetActive(true);
                BlueHead.SetActive(false);
                PurpleHead.SetActive(false);
                //For the bullet
                redon = false;
                yellowon = true;
                greenon = false;
                blueon = false;
                purpleon = false;
                break;
            case "Green":
                //Bullet
                currentBullet.SetActive(false);
                Redbullet.SetActive(false);
                Greenbullet.SetActive(true);
                Yellowbullet.SetActive(false);
                Bluebullet.SetActive(false);
                Purplebullet.SetActive(false);
                //Head
                currentHead.SetActive(false);
                RedHead.SetActive(false);
                GreenHead.SetActive(true);
                YellowHead.SetActive(false);
                BlueHead.SetActive(false);
                PurpleHead.SetActive(false);
                //For the bullet
                redon = false;
                yellowon = false;
                greenon = true;
                blueon = false;
                purpleon = false;
                break;
            case "Blue":
                //Bullet
                currentBullet.SetActive(false);
                Redbullet.SetActive(false);
                Greenbullet.SetActive(false);
                Yellowbullet.SetActive(false);
                Bluebullet.SetActive(true);
                Purplebullet.SetActive(false);
                //Head
                currentHead.SetActive(false);
                RedHead.SetActive(false);
                GreenHead.SetActive(false);
                YellowHead.SetActive(false);
                BlueHead.SetActive(true);
                PurpleHead.SetActive(false);
                //For the bullet
                redon = false;
                yellowon = false;
                greenon = false;
                blueon = true;
                purpleon = false;
                break;
            case "Purple":
                //Bullet
                currentBullet.SetActive(false);
                Redbullet.SetActive(false);
                Greenbullet.SetActive(false);
                Yellowbullet.SetActive(false);
                Bluebullet.SetActive(false);
                Purplebullet.SetActive(true);
                //Head
                currentHead.SetActive(false);
                RedHead.SetActive(false);
                GreenHead.SetActive(false);
                YellowHead.SetActive(false);
                BlueHead.SetActive(false);
                PurpleHead.SetActive(true);
                //For the bullet
                redon = false;
                yellowon = false;
                greenon = false;
                blueon = false;
                purpleon = true;
                break;
            default: break;
        }
        
        //Bots
        float distR = Vector3.Distance(transform.position, RedBot.position);
        if (distR <= radius) 
        {
            Debug.Log("Red enemy nearby!");
            LookRotationRed();
        }

        float distB = Vector3.Distance(transform.position, BlueBot.position);
        if (distB <= radius)
        {
            Debug.Log("Blue enemy nearby!");
            LookRotationBlue();
        }

        float distY = Vector3.Distance(transform.position, YellowBot.position);
        if (distY <= radius)
        {
            Debug.Log("Yellow enemy nearby!");
            LookRotationYellow();
        }

        float distG = Vector3.Distance(transform.position, GreenBot.position);
        if (distG <= radius)
        {
            Debug.Log("Green enemy nearby!");
            LookRotationGreen();
        }

        float distP = Vector3.Distance(transform.position, PurpleBot.position);
        if (distP <= radius)
        {
            Debug.Log("Purple enemy nearby!");
            LookRotationPurple();
        } 
    }

    //Looking/Aiming at an enemy
    void LookRotationRed()
    {
        Vector3 relativePos = RedBot.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }

    void LookRotationGreen()
    {
        Vector3 relativePos = GreenBot.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }

    void LookRotationYellow()
    {
        Vector3 relativePos = YellowBot.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }
    void LookRotationBlue()
    {
        Vector3 relativePos = BlueBot.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }

    void LookRotationPurple()
    {
        Vector3 relativePos = PurpleBot.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }

    //Gizmos/Radius
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    //Uh Oh, dead :(
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Red" || other.gameObject.tag == "Yellow" || other.gameObject.tag == "Green" || other.gameObject.tag == "Blue" || other.gameObject.tag == "Purple")
        { 
            //Base.SetActive(false);
            Text.SetActive(true);
        }
    }
}
