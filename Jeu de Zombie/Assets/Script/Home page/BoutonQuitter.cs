using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class BoutonQuitter : MonoBehaviour
{
    public void Quitter()
    {
        // Affiche un message dans l'éditeur
        Debug.Log("Le jeu va se fermer !");
        EditorApplication.isPlaying = false; // Arrête le mode Play
        Debug.Log("Play Mode arrêté.");
    }
}
