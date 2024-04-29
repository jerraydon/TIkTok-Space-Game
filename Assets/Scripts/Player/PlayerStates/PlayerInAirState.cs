using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInAirState : PlayerState {

    protected int xInput;

    protected bool isGrounded;

    public PlayerInAirState(PlayerStateMachine stateMachine, PlayerInputHandler inputHandler, Player player, PlayerData playerData, string animBoolName) : base(stateMachine, inputHandler, player, playerData, animBoolName) {
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

        player.SetVelocityX(xInput * playerData.speed);
        player.CheckIfShouldFlip(xInput);

        if(isGrounded) {
            stateMachine.ChangeState(stateMachine.IdleState);
        }
    }

    public override void PhysicsUpdate() {
        base.PhysicsUpdate();
    }
}
