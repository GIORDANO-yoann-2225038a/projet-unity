using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MovementEnnemis : MonoBehaviour
{
    public Transform cible; // La cible vers laquelle se déplacer
    public float vitesse = 1f; // Vitesse de déplacement
    public Point pointScore;
    public RespawnEnnemis respawnScript; // Référence au script RespawnEnnemis
    private EnnemisHealth ennemisHealth; // Référence au script EnnemisHealth
    public AudioSource soundZombie;
    public AudioClip impact;
    public AudioClip attack;
    public int etageZombie;
    public Deplacement posPlayer;
    public Animator animations; 
    private bool isRun = false;
    private bool isAttack = false;
    public bool isDead = false;

    void Start()
    {
        // Récupérer la référence au script EnnemisHealth attaché à ce GameObject
        cible = GameObject.Find("Sprite").GetComponent<Transform>();
        ennemisHealth = GetComponent<EnnemisHealth>();
        posPlayer = GameObject.Find("Sprite").GetComponent<Deplacement>();
        soundZombie = GameObject.Find("Zombie1").GetComponent<AudioSource>();
        pointScore = GameObject.Find("Score").GetComponent<Point>();
        respawnScript = GameObject.Find("RespawnObject").GetComponent<RespawnEnnemis>();
        animations = gameObject.GetComponent<Animator>();

    }
    
    void Update()
    {
        if(isDead != true)
        {   
            Move();
        }
    }

    public void Move()
    {
         if (cible != null && posPlayer.etages==etageZombie && posPlayer.zone==true)
        {
            isRun = true;
            isAttack = false;
            // Calculer la direction vers la cible
            Vector3 direction = (cible.position - transform.position).normalized;

            // Déplacer l'objet vers la cible
            
                transform.position += direction * vitesse * Time.deltaTime;
                 // Optionnel : Faire tourner l'objet pour qu'il fasse face à la cible
                 Quaternion lookRotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 3);
                animations.SetBool("IsRun", isRun);
        }
               else 
        {
            isRun = false;
            animations.SetBool("IsRun", isRun);
        }   

    }

      // Fonction pour gérer les collisions
    void OnCollisionEnter(Collision collision)
    {  
        if (collision.gameObject.CompareTag("Balle")) 
         {
            ennemisHealth.TakeDamageEnnemis(25);
            soundZombie.PlayOneShot(impact);
            if (ennemisHealth.currenthealthEnnemis <= 0)
            {
                //soundZombie.Stop();
                isDead = true;
                isRun = false;
                animations.SetBool("IsDead",isDead);
                pointScore.AddPoint();  
                respawnScript.StartCoroutine(respawnScript.RespawnEnemy(gameObject));
                ennemisHealth.currenthealthEnnemis = ennemisHealth.maxHealthEnnemis;
            }
        }   
        else if (collision.transform.CompareTag("Player")) 
        {
            PlayerHealth playerHealth = collision.transform.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(10);
            isAttack = true;
            isRun = false;
            animations.SetBool("IsAttack", isAttack);
            soundZombie.PlayOneShot(attack);
            
            
        }     
    }
    void OnCollisionExit(Collision collision)
    {
            isAttack = false;
            animations.SetBool("IsAttack", isAttack);
    }

}
