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
     public ParticleSystem walkParticles; 

    void Start ()
    {
        animations = GameObject.Find("Soldier").GetComponent<Animator>();
        walkParticles = GameObject.Find("Pas").GetComponent<ParticleSystem>();
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
                // Activer les particules si elles ne sont pas déjà actives

                Debug.Log("Test");
                walkParticles.Play();
           
            }

        }
        else
        {
            isRun = false;
            animations.SetBool("IsRun", isRun);
            movementSpeed =3f;
            if (walkParticles.isPlaying)
            {
                walkParticles.Stop();
            }
        }
        transform.Translate(0,0,verticalInput*movementSpeed * Time.deltaTime);
    }
}
