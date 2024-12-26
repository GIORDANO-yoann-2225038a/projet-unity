using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecupCle : MonoBehaviour
{
    public  Deplacement cle ;
    public Vector3 positionCle;
    private Vector3 AreaMin = new Vector3(-10, 0, -10); // Zone minimale pour le respawn
    private Vector3 AreaMax = new Vector3(10, 0, 10);   // Zone maximale pour le respawn
    void Start()
    {
             // Calculer une nouvelle position aléatoire avant de réactiver la balle
        positionCle = new Vector3(Random.Range(AreaMin.x, AreaMax.x),transform.position.y,Random.Range(AreaMin.z, AreaMax.z));
        transform.position = positionCle;
        
    }

    void OnTriggerEnter(Collider collision)
    {
         if (collision.tag == "Player")
        {
           Debug.Log("Le joueur a récupéré la clé");
           cle.recup = true;
           Destroy(gameObject);
        }
    }
}
