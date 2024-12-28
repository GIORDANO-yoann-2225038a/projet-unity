using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viseur : MonoBehaviour
{
    public Camera playerCamera;
    public float zoom = 30f;
    public float normalZoom = 80f; 
    public RotationCam cam;
    public RotationPlayer camPlayer;
    public Deplacement speed;

    public void ViseurZoom()
    {
            playerCamera.fieldOfView = Mathf.Lerp(playerCamera.fieldOfView, zoom, Time.deltaTime * 5f);
            cam.speedRotate=2f;
            camPlayer.speedRotate = 2f;
            speed.movementSpeed = 1f;
    }
    public void ViseurNormal()
    {
        playerCamera.fieldOfView = Mathf.Lerp(playerCamera.fieldOfView, normalZoom, Time.deltaTime * 5f);
        cam.speedRotate=12f;
        camPlayer.speedRotate= 12f;
        speed.movementSpeed = 5f;

    }
    
}
