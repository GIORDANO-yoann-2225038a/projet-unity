using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Point : MonoBehaviour
{
    public TextMeshProUGUI point;
    private int scores = 0; 
    // Update is called once per frame
    void Update()
    {
        point.text = scores.ToString();
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