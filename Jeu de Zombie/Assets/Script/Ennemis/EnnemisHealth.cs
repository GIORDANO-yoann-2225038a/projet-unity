using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemisHealth : MonoBehaviour
{

    public int maxHealthEnnemis;
    public int currenthealthEnnemis;
    public HealthBarEnnemis healthBarEnnemis;

    // Start is called before the first frame update
    void Start()
    {
        currenthealthEnnemis=maxHealthEnnemis;
        healthBarEnnemis.SetHealthBar(maxHealthEnnemis); 
    }

    // Update is called once per frame
    void Update()
    {
    if(Input.GetKeyDown(KeyCode.H))
        {
            TakeDamageEnnemis(10);
        }
    }

    public void TakeDamageEnnemis(int damage)
    {
        currenthealthEnnemis -= damage;
        healthBarEnnemis.SetHealthBar(currenthealthEnnemis);   
    }
}
