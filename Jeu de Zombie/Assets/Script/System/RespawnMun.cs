using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnMun : MonoBehaviour
{
    public List<GameObject> balles; // Liste des balles
    public float respawnDelay = 10f; // Délai avant le respawn
    public Vector3 respawnAreaMin = new Vector3(-10, 0, -10); // Zone minimale pour le respawn
    public Vector3 respawnAreaMax = new Vector3(10, 0, 10);   // Zone maximale pour le respawn

    private Vector3 randomPosition;  // Stocke la position aléatoire

    void Update()
    {
        // Vérifier si une balle est désactivée
        foreach (GameObject balle in balles)
        {
            if (!balle.activeSelf)
            {
                // Si la balle est désactivée, démarrer le respawn pour cette balle
                StartCoroutine(RespawnBalle(balle));
            }
        }
    }

    // Coroutine pour respawn d'une balle après un délai
    public IEnumerator RespawnBalle(GameObject balle)
    {
        // Calculer une nouvelle position aléatoire avant de réactiver la balle
        randomPosition = new Vector3(
            Random.Range(respawnAreaMin.x, respawnAreaMax.x),
            balle.transform.position.y, // Conserver la hauteur initiale
            Random.Range(respawnAreaMin.z, respawnAreaMax.z)
        );
        // Réinitialiser la position de la balle
        balle.transform.position = randomPosition;
        // Attendre un certain délai avant de réactiver la balle
        yield return new WaitForSeconds(respawnDelay);
        balle.SetActive(true);
    }
}
