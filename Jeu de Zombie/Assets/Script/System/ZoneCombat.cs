using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneCombat : MonoBehaviour
{
    public bool combatZone;
    public Deplacement zonePlayer;

     void Start ()
    {
        zonePlayer = GameObject.Find("Sprite").GetComponent<Deplacement>();
    }

    // Détecte si le joueur entre dans la zone de combat
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Vérifie si l'objet entrant a le tag "Player"
        {
            zonePlayer.zone=combatZone;
            Debug.Log("Le joueur est entré dans la zone de combat.");
        }
    }
}