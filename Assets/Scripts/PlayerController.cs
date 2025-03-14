using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }

    void FixedUpdate()
    {
        float moveHorizontal =  Input.GetAxis("Horizontal");
        float moveVertical =  Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(move * speed);
        
    }
}