using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {

    private Rigidbody2D rb;

    [SerializeField] private float fallSpeed = 2f;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        rb.velocity = -transform.right * fallSpeed * Time.fixedDeltaTime;
    }

}
