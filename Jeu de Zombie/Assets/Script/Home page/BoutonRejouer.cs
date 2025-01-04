using UnityEngine;
using UnityEngine.SceneManagement;

public class BoutonRejouer : MonoBehaviour
{
    public void Rejouer()
    {
        
        SceneManager.LoadScene("SampleScene");
    }
}
