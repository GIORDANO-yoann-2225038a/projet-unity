using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{
//movement speed in units per second
    public float movementSpeed = 3f;
    public bool recup = false;
    public int etages;
    public bool zone;
    public bool isRun= false;
    public Animator animations;

    void Start ()
    {
        animations = GameObject.Find("Soldier").GetComponent<Animator>();
    }

    void Update()
    {
        // Récupérer les entrées des axes
        float verticalInput = Input.GetAxis("Vertical");
        bool isMoving = verticalInput != 0;
        animations.SetBool("IsWalk", isMoving); 
        animations.SetFloat("vertical", verticalInput);
        if(verticalInput >0)
        {
            isRun = Input.GetButton("Run");
            animations.SetBool("IsRun",isRun);
            if(isRun == true && verticalInput >0)
            {
                movementSpeed = 5f;
            }

        }
        else
        {
            isRun = false;
            animations.SetBool("IsRun", isRun);
            movementSpeed =3f;
        }
        transform.Translate(0,0,verticalInput*movementSpeed * Time.deltaTime);
    }
}
