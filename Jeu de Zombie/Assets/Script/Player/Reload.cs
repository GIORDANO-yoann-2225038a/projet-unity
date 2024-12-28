using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour
{
    public Animator animations; // Référence à l'Animator
    public float reloadTime = 2f; // Temps de rechargement
    private bool isReloading = false; // Indicateur de rechargement en cours

    void Start()
    {
        animations = GameObject.Find("Soldier").GetComponent<Animator>();
    }

    void Update()
    {
        // Détecter la commande de rechargement (par défaut "R")
        if (Input.GetKeyDown("r"))
        {
            
            animations.SetBool("IsReload", true);
            StartCoroutine(ReloadAnim());
            Debug.Log("reload");
        }
        
    }

    IEnumerator ReloadAnim()
    {
        isReloading = true;

        // Jouer l'animation de rechargement
        

        // Attendre la durée de l'animation
        yield return new WaitForSeconds(reloadTime);

        // Fin de l'animation de rechargement
        animations.SetBool("IsReload", false);

        // Terminer le rechargement
        isReloading = false;
    }
}
