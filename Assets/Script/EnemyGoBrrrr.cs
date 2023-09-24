using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGoBrrrr : MonoBehaviour
{
    float x, y, z;
    public Vector3 currentEulerAngles;
    public Quaternion currentRotation;
    public Transform Machine;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookRotation();
        transform.position = Vector3.MoveTowards(this.transform.position, Machine.position, 10 * Time.deltaTime);
    }

    void LookRotation()
    {
        Vector3 relativePos = Machine.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }
}
