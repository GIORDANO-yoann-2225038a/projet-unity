using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecupPiece : MonoBehaviour
{
    public Projectile balle;
    private int balleRestant;
    public TextMeshProUGUI textmun;
    public Animator animations;


    void Start()
    {
        balle = GameObject.Find("Pistolet").GetComponent<Projectile>();
        textmun = GameObject.Find("Munition").GetComponent<TextMeshProUGUI>();
        animations = GameObject.Find("Soldier").GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Le joueur a récupéré la pièce");
            if(balle.munitionMax >20 && balle.munitionMax <30)
            {
                balleRestant = 30 - balle.munitionMax;
                balle.munitionMax += balleRestant;
                textmun.text = balle.munition.ToString()+" / "+balle.munitionMax.ToString();
                 // Jouer l'animation et le son de rechargement

                
                DestroyObj();
            }
            else if (balle.munitionMax==30)
            {
                Debug.Log("Charger Plein");
            }
            else
            {
                balle.munitionMax+=10;
                textmun.text = balle.munition.ToString()+" / "+balle.munitionMax.ToString();
                DestroyObj();
            }
            
        }
    }
 
    void DestroyObj()
    {
        this.gameObject.SetActive(false);
        
    }

}