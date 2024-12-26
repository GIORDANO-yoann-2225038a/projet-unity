using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecupCoffre : MonoBehaviour
{ 
    public PlayerHealth vie;
    private int vieRestant;
    public TextMeshProUGUI textVie;
    public HealthBar healthBar;
    

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Le joueur a récupéré la pièce");
            if(vie.currenthealth >85 && vie.currenthealth <100)
            {
                vieRestant = vie.maxHealth - vie.currenthealth;
                vie.currenthealth += vieRestant;
                healthBar.SetHealthBar(vie.currenthealth); 
                textVie.text = vie.currenthealth.ToString()+" / 100";
                DestroyObj();
            }
            else if (vie.currenthealth==100)
            {
                Debug.Log("Vie Plein");
            }
            else
            {
                vie.currenthealth+=15;
                healthBar.SetHealthBar(vie.currenthealth); 
                textVie.text = vie.currenthealth.ToString()+" / 100";
                DestroyObj();
            }
            
        }
    }
    void DestroyObj()
    {
        this.gameObject.SetActive(false);
    }

}
