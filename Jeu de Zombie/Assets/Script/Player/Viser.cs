using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viser : MonoBehaviour
{
    public Camera playerCamera;
    public float zoom = 30f;
    public float normalZoom = 80f; 
    public RotationCam cam;


    // Update is called once per frame
    public void Viseur()
    {
        if (Input.GetButton("Zoom")) // Clic droit pour viser (zoom)
        {
            playerCamera.fieldOfView = Mathf.Lerp(playerCamera.fieldOfView, zoom, Time.deltaTime * 5f);
            cam.speedRotate=2f;
        }
        else
        {
            playerCamera.fieldOfView = Mathf.Lerp(playerCamera.fieldOfView, normalZoom, Time.deltaTime * 5f);
            cam.speedRotate=12f;
        }
    }
}
