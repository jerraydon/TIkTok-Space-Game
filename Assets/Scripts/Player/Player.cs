using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Animator Anim { get; private set; }
    public Vector2 CurrentVelocity { get; private set; }
    public int CurrentFlipDirection { get; private set; }

    public PlayerData playerData;

    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private PlayerStateMachine stateMachine;

    [SerializeField] private Transform groundCheck;

    private Vector2 workSpace;

    private void Awake() {
        Anim = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponentInChildren<SpriteRenderer>();

        stateMachine = GetComponent<PlayerStateMachine>();

        SetFlipDirection(1);
    }

    private void Update() {
        CurrentVelocity = rb.velocity;
    }

    public void SetVelocityX(float value) {
        workSpace = new Vector2(value, rb.velocity.y);
        rb.velocity = workSpace;
        CurrentVelocity = workSpace;
    }

    public void SetVelocityY(float value) {
        workSpace = new Vector2(rb.velocity.x, value);
        rb.velocity = workSpace;
        CurrentVelocity = workSpace;
    }

    public bool CheckIfGrounded() {
        return Physics2D.OverlapCircle(groundCheck.position, playerData.groundCheckRadius, playerData.whatIsGround);
    }

    public void CheckIfShouldFlip(int xInput) {
        if (xInput == 0) return;

        if (xInput != CurrentFlipDirection) {
            CurrentFlipDirection = xInput;
            sr.flipX = !sr.flipX;
        }
    }

    public void SetFlipDirection(int direction) {
        CurrentFlipDirection = direction;

        if (direction > 0) sr.flipX = false;
        else sr.flipX = true;
    }

}
