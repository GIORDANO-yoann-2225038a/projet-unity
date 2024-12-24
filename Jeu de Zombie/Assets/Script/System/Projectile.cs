using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Projectile : MonoBehaviour
{
    public GameObject projectilePrefab;  // Prefab du projectile
    private float projectileSpeed = 20f;  // Vitesse du projectile
    private float projectileLifetime = 5f;  // Durée de vie du projectile
    public int munition ; 
    public TextMeshProUGUI textmun;

    void Update()
    {
        if(munition != 0)
        {
            // Si la touche Espace est appuyée
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                // Appel de la fonction pour tirer un projectile
                TirerProjectile();
            }
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
        munition-=1;
        textmun.text = munition.ToString();
        // Détruit le projectile après un certain temps pour éviter d'accumuler trop d'objets

        Destroy(projectile, projectileLifetime);
    }
        void OnCollisionEnter(Collision collision)
        {
            // Vous pouvez vérifier ici si le GameObject touché a un certain tag
            if (collision.gameObject.CompareTag("Ennemis")) 
            {
                    Debug.Log("TEst");
                    Destroy(gameObject);
            } 
        }

}
