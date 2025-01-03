using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void Jouer()
    {
        // Charge la scène du jeu principal
        SceneManager.LoadScene("SampleScene");
    }


}
