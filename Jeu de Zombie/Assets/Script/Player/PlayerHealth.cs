using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth;
    public int currenthealth;
    public HealthBar healthBar;
    public bool isInvicible = false;
    public TextMeshProUGUI textPointHeal;

    // Start is called before the first frame update
    void Start()
    {
        healthBar = GameObject.Find("HealthBar").GetComponent<HealthBar>();
        textPointHeal = GameObject.Find("PointHeal").GetComponent<TextMeshProUGUI>();
        currenthealth=maxHealth;
        healthBar.SetHealthBar(maxHealth); 
        textPointHeal.text = currenthealth.ToString()+" / 100";
    }
    
    public void TakeDamage(int damage)
    {
       
            currenthealth -= damage;
            healthBar.SetHealthBar(currenthealth); 
            textPointHeal.text = currenthealth.ToString()+" / 100";
            isInvicible = true;
            //StartCoroutine(PlayerInvicible());
        
                    // Quand les vies sont à 0, le Playmode s'arrête.
        if(currenthealth <= 0f){
            SceneManager.LoadScene("GameOver");
        } 
  
    }
    public IEnumerator PlayerInvicible()
    {
        yield return new WaitForSeconds(1f);
        isInvicible = false;
    }

}
