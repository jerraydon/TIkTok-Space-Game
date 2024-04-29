using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="PlayerData")]
public class PlayerData : ScriptableObject {

    [Header("Movement")]
    public float speed = 2f;
    public float jumpHeight = 3f;

    [Header("Check Variables")]
    public float groundCheckRadius = 0.2f;
    public LayerMask whatIsGround;

}
