using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBalle : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        // Vérifiez si le GameObject touché a le tag "Ennemis"
        if (collision.gameObject.CompareTag("Ennemis"))
        {
            Debug.Log("Touché");
            Destroy(gameObject); // Détruire ce projectile
        }
    }
}


