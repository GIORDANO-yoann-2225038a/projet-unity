using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Animator animations;

    void Start ()
    {
        animations = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Si le joueur se déplace horizontalement ou verticalement
        if (horizontalInput != 0 || verticalInput != 0)
        {
            animations.SetBool("isRun", true);
        }
        else if (Input.GetButton("Fire1"))
        {
            animations.SetBool("IsShoot",true);
        }
         else if (Input.GetButton("Zoom"))
        {
            animations.SetBool("IsPoint",true);
        }
        else
        {
            animations.SetBool("isRun",false);
            animations.SetBool("IsShoot",false);
            animations.SetBool("IsPoint",false);
        }

    }
}
