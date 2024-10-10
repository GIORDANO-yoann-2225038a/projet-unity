using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEnnemis : MonoBehaviour
{
    public Transform cible; // La cible vers laquelle se déplacer
    public float vitesse = 5f; // Vitesse de déplacement
    

    void Update()
    {
        if (cible != null)
        {
            // Calculer la direction vers la cible
            Vector3 direction = (cible.position - transform.position).normalized;

            // Déplacer l'objet vers la cible
            transform.position += direction * vitesse * Time.deltaTime;

            // Optionnel : Faire tourner l'objet pour qu'il fasse face à la cible
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * vitesse);
        }
        
    }
      // Fonction pour gérer les collisions
    void OnCollisionEnter(Collision collision)
    {
        // Vous pouvez vérifier ici si le GameObject touché a un certain tag
        if (collision.gameObject.name=="Projectile(Clone)") 
         {
            
            Destroy(gameObject); // Détruire cet objet
        }

        
    }
}
