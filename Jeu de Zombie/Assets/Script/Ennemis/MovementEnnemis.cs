using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MovementEnnemis : MonoBehaviour
{
    public Transform cible; // La cible vers laquelle se déplacer
    public float vitesse = 5f; // Vitesse de déplacement
    public Point pointScore;
    public RespawnEnnemis respawnScript; // Référence au script RespawnEnnemis
    private EnnemisHealth ennemisHealth; // Référence au script EnnemisHealth

    void Start()
    {
        // Récupérer la référence au script EnnemisHealth attaché à ce GameObject
        ennemisHealth = GetComponent<EnnemisHealth>();
    }
    
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
            ennemisHealth.TakeDamageEnnemis(10);
            if (ennemisHealth.currenthealthEnnemis <= 0)
            {
                pointScore.AddPoint();  
                gameObject.SetActive(false); // Détruire cet objet
                ennemisHealth.currenthealthEnnemis = ennemisHealth.maxHealthEnnemis;
                respawnScript.StartCoroutine(respawnScript.RespawnEnemy(gameObject));
            }
            
            
          
        }   
        else if (collision.transform.CompareTag("Player")) 
        {
            PlayerHealth playerHealth = collision.transform.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(10);
        }     
    }

}
