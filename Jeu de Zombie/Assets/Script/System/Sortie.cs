using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class Sortie : MonoBehaviour
{
    public Deplacement cle; 

    void OnTriggerEnter(Collider collision)
    {
        // Vérifiez si le GameObject touché a le tag "Ennemis"
        if (collision.tag == "Player" && cle.recup==true )
        {
            Destroy(gameObject); // Détruire ce projectile
            EditorApplication.isPlaying = false; // Arrête le mode Play
            Debug.Log("Play Mode arrêté.");
        }
    }
}

