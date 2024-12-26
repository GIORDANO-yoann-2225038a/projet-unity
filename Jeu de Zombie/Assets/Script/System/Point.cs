using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Point : MonoBehaviour
{
    public TextMeshProUGUI point;
    private int scores = 0; 
    public RecupCle cle;
    // Update is called once per frame
    void Start()
    {
        cle.gameObject.SetActive(false);
    }
    void Update()
    {
        point.text ="Score : " +scores.ToString();
        if(scores == 20)
        {
            cle.gameObject.SetActive(true);
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