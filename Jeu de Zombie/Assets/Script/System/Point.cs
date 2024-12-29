using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Point : MonoBehaviour
{
    public TextMeshProUGUI point;
    private int scores = 0; 
    public RecupCle scoreCle;
    
    void Start()
    {
        scoreCle= GameObject.Find("cle").GetComponent<RecupCle>();
    }
    void Update()
    {
        point.text ="Score : " +scores.ToString();
         if(scores == 200)
        {
            scoreCle.gameObject.SetActive(true);
        }
        
    }
    public void AddPoint()
    {
        scores+=10;
    }
    public void DestroyEnnemis()
    {
        AddPoint();
    }
    
}