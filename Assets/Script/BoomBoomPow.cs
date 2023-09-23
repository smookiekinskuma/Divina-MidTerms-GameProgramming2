using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomBoomPow : MonoBehaviour
{
    float x, y, z;
    public Vector3 currentEulerAngles;
    public Quaternion currentRotation;
    public float rotSpeed;

    public Transform RedBot, GreenBot, YellowBot, BlueBot, PurpleBot;

    float timeCount = 0.0f;

    public float radius;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float distR = Vector3.Distance(transform.position, RedBot.position);
        if (distR <= radius) 
        {
            Debug.Log("Red enemy nearby!");
        }

        float distG = Vector3.Distance(transform.position, GreenBot.position);
        if (distG <= radius)
        {
            Debug.Log("Green enemy nearby!");
        }

        float distY = Vector3.Distance(transform.position, YellowBot.position);
        if (distY <= radius)
        {
            Debug.Log("Yellow enemy nearby!");
        }

        float distB = Vector3.Distance(transform.position, BlueBot.position);
        if (distB <= radius)
        {
            Debug.Log("Blue enemy nearby!");
        }

        float distP = Vector3.Distance(transform.position, PurpleBot.position);
        if (distP <= radius)
        {
            Debug.Log("Purple enemy nearby!");
        }

        LookRotation();
    }

    void LookRotation()
    {
        Vector3 relativePos = RedBot.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
