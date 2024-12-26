using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5f; // Vitesse de déplacement
    public float rotationSpeed = 10f; // Vitesse de rotation
    private Rigidbody rb; // Référence au Rigidbody
    private Vector3 movementInput; // Stocke l'entrée de mouvement

    void Start()
    {
        // Récupérer le Rigidbody attaché au joueur
        rb = GetComponent<Rigidbody>();
    }

    // Méthode appelée par Player Input
    public void OnMove(InputValue value)
    {
        // Récupérer l'entrée en tant que Vector2
        Vector2 inputVector = value.Get<Vector2>();
        movementInput = new Vector3(inputVector.x, 0, inputVector.y);
    }

    void Update()
    {
        // Rotation pour faire face à la direction du mouvement
        if (movementInput != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movementInput);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }

    void FixedUpdate()
    {
        // Appliquer le mouvement
        Vector3 movement = movementInput * movementSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);
    }
}
