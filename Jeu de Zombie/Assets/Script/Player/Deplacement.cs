using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{
//movement speed in units per second
    public float movementSpeed = 5f;
    public bool recup = false;
    public int etages;
    public bool isRun= false;
    public Animator animations;

    void Start ()
    {
        animations = GameObject.Find("Soldat").GetComponent<Animator>();
    }

    void Update()
    {
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
                // Si le joueur se déplace horizontalement ou verticalement
        if (verticalInput > 0 )
        {
            animations.SetBool("IsRun", true);
            animations.SetFloat("vertical",verticalInput);
        }
        
        else if (verticalInput < 0 )
        {
            Debug.Log(verticalInput);
            animations.SetBool("IsRun", true);
            animations.SetFloat("vertical",verticalInput);
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
            animations.SetBool("IsRun",false);
            animations.SetBool("IsShoot",false);
            animations.SetBool("IsPoint",false);
        }

        //update the position
        transform.Translate(horizontalInput*movementSpeed * Time.deltaTime,0,verticalInput*movementSpeed * Time.deltaTime);
 

    }
}
