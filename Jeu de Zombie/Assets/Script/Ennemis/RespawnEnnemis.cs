using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnEnnemis : MonoBehaviour
{
    public List<GameObject> ennemis; // Liste des ennemis
    public float respawnDelay = 10f; // Délai avant le respawn
    public Vector3 respawnAreaMin = new Vector3(-10, 0, -10); // Zone minimale pour le respawn
    public Vector3 respawnAreaMax = new Vector3(10, 0, 10);   // Zone maximale pour le respawn
    private Vector3 randomPosition;  // Stocke la position aléatoire

    void Update()
    {
        // Vérifier si un ennemi est désactivé
        foreach (GameObject ennemi in ennemis)
        {
            if (!ennemi.activeSelf)
            {
                // Si l'ennemi est désactivé, démarrer le respawn pour cet ennemi
                StartCoroutine(RespawnEnemy(ennemi));
            }
        }
    }

    // Coroutine pour respawn d'un ennemi après un délai
    public IEnumerator RespawnEnemy(GameObject ennemi)
    {

             // Calculer une nouvelle position aléatoire avant de réactiver la balle
        randomPosition = new Vector3(
            Random.Range(respawnAreaMin.x, respawnAreaMax.x),
            ennemi.transform.position.y, // Conserver la hauteur initiale
            Random.Range(respawnAreaMin.z, respawnAreaMax.z)
        );
        // Réinitialiser la position de l'ennemi
        ennemi.transform.position = randomPosition;
        // Attendre un certain délai avant de réactiver l'ennemi
        yield return new WaitForSeconds(respawnDelay);

        // Réactiver l'ennemi
        ennemi.SetActive(true);

        
        
    }
}
