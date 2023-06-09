using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Mount : MonoBehaviour
{
    public Rigidbody rb;


    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(0, 0, 150);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(-150, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(150, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(0, 0, -150);
        }
    }
}
