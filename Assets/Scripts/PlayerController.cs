using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
   private Rigidbody Rb;
   private Float MovementX;
   private Float MovementY;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue MovementValue)
    {
        Vector2 MovementVector = MovementValue.Get<Vector2>();

        MovementX = MovementVector.x;
        MovementY = MovementVector.y;
    }

    void FixedUpdate()
    {
        Vector3 Movement = New Vector3(MovementX, 0.0f, MovementY);
        
        Rb.AddForce(Movement);
    }
}
