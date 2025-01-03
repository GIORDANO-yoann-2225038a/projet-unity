using UnityEngine;

public class BoutonRegles : MonoBehaviour
{
    public GameObject texteRegles;

    public void AfficherRegles()
    {
        // Active ou désactive le texte des règles
        if (texteRegles != null)
        {
            texteRegles.SetActive(!texteRegles.activeSelf);
        }
    }
}
