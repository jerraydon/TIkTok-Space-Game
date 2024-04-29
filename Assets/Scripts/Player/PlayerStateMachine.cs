using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : MonoBehaviour {

    private Player player;
    private PlayerInputHandler inputHandler;

    public PlayerState CurrentState { get; private set; }

    public PlayerIdleState IdleState { get; private set; }
    public PlayerMoveState MoveState { get; private set; }
    public PlayerJumpState JumpState { get; private set; }
    public PlayerInAirState InAirState { get; private set; }

    private void Awake() {
        player = GetComponent<Player>();
        inputHandler = GetComponent<PlayerInputHandler>();

        IdleState = new PlayerIdleState(this, inputHandler, player, player.playerData, "idle");
        MoveState = new PlayerMoveState(this, inputHandler, player, player.playerData, "move");
        JumpState = new PlayerJumpState(this, inputHandler, player, player.playerData, "inAir");
        InAirState = new PlayerInAirState(this, inputHandler, player, player.playerData, "inAir");
    }

    private void Start() {
        Init(IdleState);
    }

    private void Update() {
        CurrentState.LogicUpdate();
    }

    private void FixedUpdate() {
        CurrentState.PhysicsUpdate();
    }

    private void Init(PlayerState state) {
        CurrentState = state;
        CurrentState.Enter();
    }

    public void ChangeState(PlayerState newState) {
        CurrentState.Exit();
        CurrentState = newState;
        CurrentState.Enter();
    }

}
