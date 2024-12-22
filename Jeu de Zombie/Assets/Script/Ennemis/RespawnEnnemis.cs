using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnEnnemis : MonoBehaviour
{
    public List<GameObject> ennemis; // Liste des ennemis
    public float respawnDelay = 10f; // Délai avant le respawn
    public float minX = -10f; // Position minimale sur l'axe X
    public float maxX = 10f;  // Position maximale sur l'axe X
    public float minZ = -10f; // Position minimale sur l'axe Z
    public float maxZ = 10f;  // Position maximale sur l'axe Z

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
        // Attendre un certain délai avant de réactiver l'ennemi
        yield return new WaitForSeconds(respawnDelay);

        // Réactiver l'ennemi
        ennemi.SetActive(true);

        // Générer une position aléatoire sur les axes X et Z
        float randomX = Random.Range(minX, maxX);
        float randomZ = Random.Range(minZ, maxZ);

        // Réinitialiser la position de l'ennemi
        ennemi.transform.position = Vector3.zero;
    }
}
