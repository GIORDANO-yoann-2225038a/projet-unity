using UnityEngine;
using UnityEngine.SceneManagement;

public class BoutonRejouer : MonoBehaviour
{
    public void Rejouer()
    {
        // Recharge la scène actuelle
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
