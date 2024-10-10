using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
     public GameObject projectilePrefab;  // Prefab du projectile
    public float projectileSpeed = 20f;  // Vitesse du projectile
    public float projectileLifetime = 5f;  // Durée de vie du projectile

    void Update()
    {
        // Si la touche Espace est appuyée
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // Appel de la fonction pour tirer un projectile
            TirerProjectile();
        }
    }

    // Fonction pour tirer un projectile
    void TirerProjectile()
    {
        // Instancie un nouveau projectile à la position et rotation de l'objet actuel
        GameObject projectile = Instantiate(projectilePrefab, transform.position+transform.forward, Quaternion.Euler(0, 90, 90));
        

        // Ajoute une force vers l'avant pour que le projectile avance
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = transform.forward * projectileSpeed;  // Applique une vitesse vers l'avant
        }
        // Détruit le projectile après un certain temps pour éviter d'accumuler trop d'objets
        Destroy(projectile, projectileLifetime);
    }

}
