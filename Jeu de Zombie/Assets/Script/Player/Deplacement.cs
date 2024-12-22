using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{
//movement speed in units per second
    public float movementSpeed = 5f;
    public float speedRotate = 5f;

    void Update()
    {
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        //update the position
        transform.Translate(horizontalInput*movementSpeed * Time.deltaTime,0,verticalInput*movementSpeed * Time.deltaTime);
       // Get the mouse delta. This is not in the range -1...1
        float h = speedRotate * Input.GetAxis("Mouse X");
        //float b = speedRotate * -Input.GetAxis("Mouse Y");
        

        transform.Rotate(0, h,0 );
        

    }
}
