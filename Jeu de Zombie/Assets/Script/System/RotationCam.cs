using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCam : MonoBehaviour
{
    public float speedRotate = 5f;
    private float minAngle = -20f;     // Angle minimum autorisé
    private float maxAngle = 20f;      // Angle maximum autorisé
    private float rotateX = 0f; // Rotation actuelle sur l'axe X

    // Update is called once per frame
    void Update()
    {
        
        float b = speedRotate * Input.GetAxis("Camera Y"); // Rotation verticale   
        rotateX -= b;        
        rotateX = Mathf.Clamp(rotateX, minAngle, maxAngle); 
        transform.localRotation = Quaternion.Euler(rotateX, 0, 0);
    }
}
