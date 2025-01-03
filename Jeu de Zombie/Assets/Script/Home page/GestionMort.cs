using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionMort : MonoBehaviour
{
    public int vie = 100; // La vie du joueur

    // Appelée lorsque le joueur subit des dégâts
    public void PrendreDegats(int degats)
    {
        vie -= degats;

        // Vérifie si la vie est à 0 ou moins
        if (vie <= 0)
        {
            Mort();
        }
    }

    // Gère la mort du joueur
    void Mort()
    {
        // Appelle la scène Game Over après 2 secondes
        Invoke("ChargerGameOver", 2f);
    }

    void ChargerGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

}
