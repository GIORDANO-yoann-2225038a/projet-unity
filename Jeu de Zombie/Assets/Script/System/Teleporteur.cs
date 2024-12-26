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
    void OnTriggerEnter(Collider collision)
    {
         if (collision.tag == "Player")
        {
            pos = new Vector3(escalierSortie.position.x+1,escalierSortie.position.y,escalierSortie.position.z);
            posPlayer.position = pos;
        }
        if (etage == 1)
        {
            etagePlayer.etages = etage;
        }
        else if (etage == 2)
        {
            etagePlayer.etages = etage;
        }
        else
        {
            etagePlayer.etages = 3;
        }
    }
}
