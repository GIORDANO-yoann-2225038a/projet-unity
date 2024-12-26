using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPlayer : MonoBehaviour
{
    public float speedRotate = 12f;
    public float minAngle = -45f;     // Angle minimum autorisé
    public float maxAngle = 45f;      // Angle maximum autorisé

    

    // Update is called once per frame
    void Update()
    {
        float h = speedRotate * Input.GetAxis("Camera X"); // Rotation horizontale 
        if (Mathf.Abs(h) <= maxAngle || Mathf.Abs(h) >= minAngle)
        {
            transform.Rotate(0,h,0);
        }
    }
}
