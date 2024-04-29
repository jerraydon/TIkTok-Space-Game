using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour {

    public Vector2 Movement { get; private set; }
    public Vector2 NormalizedMovement { get; private set; }

    public bool JumpInput { get; private set; }

    public void OnMovementInput(InputAction.CallbackContext context) {
        Movement = context.ReadValue<Vector2>();

        NormalizedMovement = Movement.normalized;
    }

    public void OnJumpInput(InputAction.CallbackContext context) {
        if (context.performed)
            JumpInput = true;
    }

    public void UseJumpInput() => JumpInput = false;

}
