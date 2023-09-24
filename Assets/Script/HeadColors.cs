using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadColors : MonoBehaviour
{
    public Renderer rend;
    public Color[] colors;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        
    }

    private void OnMouseDown()
    {
        rend.material.color = colors[Random.Range(0, colors.Length)];
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
