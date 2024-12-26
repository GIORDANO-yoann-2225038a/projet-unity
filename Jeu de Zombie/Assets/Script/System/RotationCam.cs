using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCam : MonoBehaviour
{
    public float speedRotate = 12f;
    public float minAngle = -45f;     // Angle minimum autorisé
    public float maxAngle = 45f;      // Angle maximum autorisé

    private float rotateX = 0f; // Rotation actuelle sur l'axe X
    private float rotateY = 0f; // Rotation actuelle sur l'axe X

    // Update is called once per frame
    void Update()
    {
        float h = speedRotate * Input.GetAxis("Camera X"); // Rotation horizontale
        float b = speedRotate * Input.GetAxis("Camera Y"); // Rotation verticale

        
        rotateX -= b;  
        rotateY += h;     
        rotateX = Mathf.Clamp(rotateX, minAngle, maxAngle);
        rotateY = Mathf.Clamp(rotateY, minAngle, maxAngle);

        
        transform.localRotation = Quaternion.Euler(rotateX, rotateY, 0);
    }
}
