using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnEnnemis : MonoBehaviour
{
    public GameObject ennemi; // Référence au GameObject de l'ennemi

    void Update()
    {
        // Vérifier si l'ennemi est désactivé
        if (!ennemi.activeSelf)
        {
            // Démarrer la coroutine de respawn si l'ennemi est désactivé
            StartCoroutine(RespawnEnemy());
        }
    }
      
    // Coroutine pour respawn de l'ennemi après un délai
    IEnumerator RespawnEnemy()
    {
        yield return new WaitForSeconds(10f); // 10 secondes de délai avant le respawn
        ennemi.SetActive(true);
        ennemi.transform.position = Vector3.zero; // Positionner l'ennemi à la position (0,0,0)
    }
}
