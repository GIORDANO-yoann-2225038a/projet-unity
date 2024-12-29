using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporteur : MonoBehaviour
{
    public Transform escalierSortie;
    public Transform posPlayer;
    private Vector3 pos;
    public int etage = 1 ;
    public Deplacement etagePlayer;
    public bool playerSortie;

    void Start()
    {
        etagePlayer = GameObject.Find("Sprite").GetComponent<Deplacement>();
        posPlayer = GameObject.Find("Sprite").GetComponent<Transform>();
    }
    void Update()
    {
         if (playerSortie == true & Input.GetButtonDown("Confirm"))
        {
            pos = new Vector3(escalierSortie.position.x,escalierSortie.position.y,escalierSortie.position.z);
            posPlayer.position = pos;
            if (etage == 1)
            {
                etagePlayer.etages = etage;
            }
            else 
            {
                etagePlayer.etages = etage;
            }
        }

    }

        void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            playerSortie = true; 
            Debug.Log("Le joueur est à côté de la porte.");
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.tag=="Player")
        {
            playerSortie = false; 
            Debug.Log("Le joueur a quitté la zone de la porte.");
        }
    }
}
