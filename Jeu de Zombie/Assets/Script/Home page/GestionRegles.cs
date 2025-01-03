using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionRegles : MonoBehaviour
{
    public GameObject panelRegles;

    // Affiche la fenêtre des règles
    public void AfficherRegles()
    {
        if (panelRegles != null)
        {
            panelRegles.SetActive(true);
        }
    }

    // Ferme la fenêtre des règles
    public void FermerRegles()
    {
        if (panelRegles != null)
        {
            panelRegles.SetActive(false);
        }
    }
}

