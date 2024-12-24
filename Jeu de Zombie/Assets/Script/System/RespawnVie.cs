using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnVie : MonoBehaviour
{
    public List<GameObject> vies; // Liste des vies
    public float respawnDelay = 10f; // Délai avant le respawn
    private Vector3 respawnAreaMin = new Vector3(-10, 0, -10); // Zone minimale pour le respawn
    private Vector3 respawnAreaMax = new Vector3(10, 0, 10);   // Zone maximale pour le respawn

    private Vector3 randomPosition;  // Stocke la position aléatoire

    void Update()
    {
        // Vérifier si une vie est désactivée
        foreach (GameObject vie in vies)
        {
            if (!vie.activeSelf)
            {
                // Si la vie est désactivée, démarrer le respawn pour cette vie
                StartCoroutine(RespawnVies(vie));
            }
        }
    }

    // Coroutine pour respawn d'une vie après un délai
    public IEnumerator RespawnVies(GameObject vie)
    {
        // Calculer une nouvelle position aléatoire avant de réactiver la vie
        randomPosition = new Vector3(
            Random.Range(respawnAreaMin.x, respawnAreaMax.x),
            vie.transform.position.y, // Conserver la hauteur initiale
            Random.Range(respawnAreaMin.z, respawnAreaMax.z)
        );
        // Réinitialiser la position de la vie
        vie.transform.position = randomPosition;
        // Attendre un certain délai avant de réactiver la vie
        yield return new WaitForSeconds(respawnDelay);
        vie.SetActive(true);
    }
}
