using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{
    public float speed = 0.01f;
    
    void Start()
    {
        playPos = transform.position;
    }
    Vector3 playPos;
    void Update()
    {
        float x = transform.position.x + Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        //Debug.Log(x);
        Vector3 newPos = new Vector3(Mathf.Clamp(x,-3.5f,3.5f), playPos.y, playPos.z);
        transform.position = newPos;
    }
}
