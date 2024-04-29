using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveState : PlayerGroundedState {
    public PlayerMoveState(PlayerStateMachine stateMachine, PlayerInputHandler inputHandler, Player player, PlayerData playerData, string animBoolName) : base(stateMachine, inputHandler, player, playerData, animBoolName) {
    }

    public override void Enter() {
        base.Enter();
    }

    public override void Exit() {
        base.Exit();
    }

    public override void LogicUpdate() {
        base.LogicUpdate();

        player.SetVelocityX(xInput * playerData.speed);
        player.CheckIfShouldFlip(xInput);

        if(xInput == 0f) {
            stateMachine.ChangeState(stateMachine.IdleState);
        } else if (jumpInput) {
            stateMachine.ChangeState(stateMachine.JumpState);
        }
    }

    public override void PhysicsUpdate() {
        base.PhysicsUpdate();
    }
}
