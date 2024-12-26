using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Point : MonoBehaviour
{
    public TextMeshProUGUI point;
    private int scores = 0; 
    public RecupCle scoreCle;
    // Update is called once per frame
    void Start()
    {
        scoreCle= GameObject.Find("cle").GetComponent<RecupCle>();
    }
    void Update()
    {
        point.text ="Score : " +scores.ToString();
         if(scores == 20)
        {
            Debug.Log("test");
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