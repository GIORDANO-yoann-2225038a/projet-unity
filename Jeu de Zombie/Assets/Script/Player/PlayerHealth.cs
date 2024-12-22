using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth;
    public int currenthealth;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currenthealth=maxHealth;
        healthBar.SetHealthBar(maxHealth); 
    }

    // Update is called once per frame
    void Update()
    {
    if(Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage(int damage)
    {
        currenthealth -= damage;
        healthBar.SetHealthBar(currenthealth); 
        // Quand les vies sont à 0, le Playmode s'arrête.
        if(currenthealth == 0f){
            EditorApplication.isPlaying = false; // Arrête le mode Play
            Debug.Log("Play Mode arrêté.");
        }   
    }

}
