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
    public int munitionMax = 30;
    public TextMeshProUGUI textmun;
    public AudioSource shoot;
    public AudioClip fire;
    public AudioClip bullet;
    public Viseur viserZoom;
    public Animator animations;

    void Start()
    {
        animations = GameObject.Find("Soldier").GetComponent<Animator>(); 
        textmun = GameObject.Find("Munition").GetComponent<TextMeshProUGUI>();    
    }

    void Update()
    {
        if(munition != 0)
        {
            // Si la touche Espace est appuyée
            if (Input.GetButtonDown("Fire1"))
            {
                // Appel de la fonction pour tirer un projectile
                animations.SetBool("IsShoot", Input.GetButton("Fire1"));
                TirerProjectile();
                shoot.PlayOneShot(fire);
                shoot.PlayOneShot(bullet);
            }
            else 
            {
                animations.SetBool("IsShoot", false);
            }
        }
        else
        {
            animations.SetBool("IsShoot", false);
        }

        if (Input.GetButton("Zoom")) // Clic droit pour viser (zoom)
        {
            animations.SetBool("IsPoint", true);
            viserZoom.ViseurZoom();
        }
        else
        {
            viserZoom.ViseurNormal();
            animations.SetBool("IsPoint", false);
            
            
        }
    }

    
    void TirerProjectile()
    {
        
        // Instancie un nouveau projectile à la position et rotation de l'objet actuel
        Quaternion angle = Quaternion.Euler(90, 0, 0);
        GameObject projectile = Instantiate(projectilePrefab, transform.position + transform.forward, transform.rotation*angle);

        // Ajoute une force vers l'avant pour que le projectile avance
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = transform.forward * projectileSpeed;  // Applique une vitesse vers l'avant
        }
        munition-=1;
        textmun.text = munition.ToString()+ " / "+ munitionMax.ToString();
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
