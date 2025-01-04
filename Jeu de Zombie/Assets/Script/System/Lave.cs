using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Lave : MonoBehaviour
{
    public Deplacement etageLave;
    public PlayerHealth viePlayer;
    public float damageInterval = 0f;
    public TextMeshProUGUI textPointHeal;
    public HealthBar healthBar;

    void Update()
    {
        damageInterval+= Time.deltaTime;
        if(etageLave.etages==1 && damageInterval >= 5.0f)
        {
            viePlayer.currenthealth -=5;
            damageInterval = 0f;
            healthBar.SetHealthBar(viePlayer.currenthealth); 
            textPointHeal.text = viePlayer.currenthealth.ToString()+" / 100";
            
        }
    }
}