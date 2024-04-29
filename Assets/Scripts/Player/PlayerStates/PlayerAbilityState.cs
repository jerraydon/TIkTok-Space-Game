using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbilityState : PlayerState {

    protected int xInput;

    protected bool isGrounded;

    public PlayerAbilityState(PlayerStateMachine stateMachine, PlayerInputHandler inputHandler, Player player, PlayerData playerData, string animBoolName) : base(stateMachine, inputHandler, player, playerData, animBoolName) {
    }

    public override void Enter() {
        base.Enter();
    }

    public override void Exit() {
        base.Exit();
    }

    public override void LogicUpdate() {
        base.LogicUpdate();

        xInput = (int)inputHandler.NormalizedMovement.x;

        isGrounded = player.CheckIfGrounded();
    }

    public override void PhysicsUpdate() {
        base.PhysicsUpdate();
    }
}
