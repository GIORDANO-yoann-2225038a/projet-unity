using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class Sortie : MonoBehaviour
{
    public Deplacement cle; 
    private bool playerSortie;

    void OnTriggerEnter(Collider collision)
    {
        
        if (collision.tag == "Player" && cle.recup==true )
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

    void Update()
    {
        if(playerSortie ==true && cle.recup==true & Input.GetButtonDown("Confirm"))
        {
            Destroy(gameObject); 
            EditorApplication.isPlaying = false; 
            Debug.Log("Play Mode arrêté.");
        }
    }
}

