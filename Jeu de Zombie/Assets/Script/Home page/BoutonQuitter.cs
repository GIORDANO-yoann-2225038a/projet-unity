using UnityEngine;

public class BoutonQuitter : MonoBehaviour
{
    public void Quitter()
    {
        // Affiche un message dans l'éditeur
        Debug.Log("Le jeu va se fermer !");
        Application.Quit();
    }
}
