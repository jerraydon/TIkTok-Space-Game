using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerGroundedState {
    public PlayerIdleState(PlayerStateMachine stateMachine, PlayerInputHandler inputHandler, Player player, PlayerData playerData, string animBoolName) : base(stateMachine, inputHandler, player, playerData, animBoolName) {
    }

    public override void Enter() {
        base.Enter();

        player.SetVelocityX(0f);
    }

    public override void Exit() {
        base.Exit();
    }

    public override void LogicUpdate() {
        base.LogicUpdate();

        if(xInput != 0f) {
            stateMachine.ChangeState(stateMachine.MoveState);
        } else if(jumpInput) {
            stateMachine.ChangeState(stateMachine.JumpState);
        }
    }

    public override void PhysicsUpdate() {
        base.PhysicsUpdate();
    }
}
