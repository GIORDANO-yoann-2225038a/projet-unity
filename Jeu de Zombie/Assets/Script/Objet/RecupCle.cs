using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecupCle : MonoBehaviour
{
    public  Deplacement cle ;
    public Point scoreCle;
    private Vector3 positionCle;
    private Vector3 AreaMin = new Vector3(-10, 0, -10); // Zone minimale pour le respawn
    private Vector3 AreaMax = new Vector3(10, 0, 10);   // Zone maximale pour le respawn
    void Start()
    {
        cle = GameObject.Find("Sprite").GetComponent<Deplacement>();
        scoreCle= GameObject.Find("Score").GetComponent<Point>();
        positionCle = new Vector3(Random.Range(AreaMin.x, AreaMax.x),transform.position.y,Random.Range(AreaMin.z, AreaMax.z));
        transform.position = positionCle;
        gameObject.SetActive(false);
        
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
