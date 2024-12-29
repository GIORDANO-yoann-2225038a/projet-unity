using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Reload : MonoBehaviour
{
    public Animator animations; // Référence à l'Animator
    public Projectile balle;
    private int balleRestant;
    public TextMeshProUGUI textmun;
    public AudioSource reload;
    
    private float reloadTime = 3f; // Temps de rechargement
    //private bool isReloading = false; // Indicateur de rechargement en cours

    void Start()
    {
        balle = GameObject.Find("Pistolet").GetComponent<Projectile>();
        animations = GameObject.Find("Soldier").GetComponent<Animator>();
        textmun = GameObject.Find("Munition").GetComponent<TextMeshProUGUI>();   
        reload = GameObject.Find("Pistolet").GetComponent<AudioSource>();   
    
    }

    void Update()
    {
        // Détecter la commande de rechargement (par défaut "Reload")
        if (Input.GetButtonDown("Reload") && balle.munitionMax>0 && balle.munition <15 )
        {
            animations.SetBool("IsReload", true);
            reload.Play();
            StartCoroutine(ReloadAnim());
            Debug.Log("reload");
            int maxChargeur = 15; 

            if (balle.munitionMax <= maxChargeur - balle.munition)
            {
                balleRestant = balle.munitionMax;
                balle.munition += balleRestant;
                balle.munitionMax = 0;
            }
            else
            {
                balleRestant = maxChargeur - balle.munition;
                balle.munition += balleRestant;
                balle.munitionMax -= balleRestant;
            }
        }
        else
        {
            Debug.Log("Plus de balle");
        }
        
    }

    IEnumerator ReloadAnim()
    {
        // Jouer l'animation de rechargement
        yield return new WaitForSeconds(reloadTime);
        // Fin de l'animation de rechargement
        animations.SetBool("IsReload", false);
        textmun.text = balle.munition.ToString()+" / "+balle.munitionMax.ToString();
    }
}
