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

        // Vérifier si le joueur se déplace
        bool isMoving = verticalInput != 0 || horizontalInput != 0;
        animations.SetBool("IsRun", isMoving);

        // Mettre à jour les paramètres de l'Animator
        animations.SetFloat("vertical", verticalInput);
        animations.SetFloat("horizontal", horizontalInput);

        // Gérer les autres actions
        animations.SetBool("IsShoot", Input.GetButton("Fire1"));
        animations.SetBool("IsPoint", Input.GetButton("Zoom"));

        //update the position
        transform.Translate(horizontalInput*movementSpeed * Time.deltaTime,0,verticalInput*movementSpeed * Time.deltaTime);
 

    }
}
