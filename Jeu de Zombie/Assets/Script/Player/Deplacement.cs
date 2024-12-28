using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{
//movement speed in units per second
    public float movementSpeed = 0.2f;
    public bool recup = false;
    public int etages;
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
        float horizontalInput = Input.GetAxis("Horizontal");

        
        bool isMoving = verticalInput != 0 || horizontalInput != 0;
        animations.SetBool("IsRun", isMoving);

        
        animations.SetFloat("vertical", verticalInput);
        animations.SetFloat("horizontal", horizontalInput);

        
        transform.Translate(horizontalInput*movementSpeed * Time.deltaTime,0,verticalInput*movementSpeed * Time.deltaTime);
 

    }
}
