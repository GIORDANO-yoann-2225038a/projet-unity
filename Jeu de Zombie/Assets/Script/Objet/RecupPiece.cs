using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecupPiece : MonoBehaviour
{
    public Projectile balle;
    private int balleRestant;
    public int balleMax;
    public TextMeshProUGUI textmun;
    public AudioSource reload;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Le joueur a récupéré la pièce");
            if(balle.munition >20 && balle.munition <30)
            {
                reload.Play();
                balleRestant = balleMax - balle.munition;
                balle.munition += balleRestant;
                textmun.text = balle.munition.ToString()+" / 30";
                DestroyObj();
            }
            else if (balle.munition==30)
            {
                Debug.Log("Charger Plein");
            }
            else
            {
                reload.Play();
                balle.munition+=10;
                textmun.text = balle.munition.ToString()+" / 30";
                DestroyObj();
            }
            
        }
    }
    void DestroyObj()
    {
        this.gameObject.SetActive(false);
    }

}
