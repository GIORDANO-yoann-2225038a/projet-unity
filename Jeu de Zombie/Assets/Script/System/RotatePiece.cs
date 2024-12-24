using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePiece : MonoBehaviour
{

    public Vector3 speedrotation;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speedrotation*Time.deltaTime);
    }
    
}
