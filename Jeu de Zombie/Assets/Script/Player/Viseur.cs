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

    // Offset pour décaler légèrement la caméra lors du zoom
    public Vector3 aimingOffset = new Vector3(0.2f, 0, 0); // Décalage vers la droite
    private Vector3 originalPosition; // Position initiale de la caméra

    void Start()
    {
        // Sauvegarder la position initiale de la caméra
        originalPosition = playerCamera.transform.localPosition;
    }

    public void ViseurZoom()
    {
        // Appliquer le zoom
        playerCamera.fieldOfView = Mathf.Lerp(playerCamera.fieldOfView, zoom, Time.deltaTime * 5f);

        // Décaler légèrement la caméra vers la droite
        playerCamera.transform.localPosition = Vector3.Lerp(
            playerCamera.transform.localPosition,
            originalPosition + aimingOffset,
            Time.deltaTime * 5f
        );

        // Réduire la vitesse de rotation et de déplacement
        cam.speedRotate = 2f;
        camPlayer.speedRotate = 2f;
        speed.movementSpeed = 1f;
    }

    public void ViseurNormal()
    {
        // Revenir au champ de vision normal
        playerCamera.fieldOfView = Mathf.Lerp(playerCamera.fieldOfView, normalZoom, Time.deltaTime * 5f);

        // Réinitialiser la position de la caméra
        playerCamera.transform.localPosition = Vector3.Lerp(
            playerCamera.transform.localPosition,
            originalPosition,
            Time.deltaTime * 5f
        );

        // Rétablir la vitesse de rotation et de déplacement
        cam.speedRotate = 12f;
        camPlayer.speedRotate = 12f;
        speed.movementSpeed = 3f;
    }
}
