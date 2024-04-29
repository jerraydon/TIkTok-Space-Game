using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpState : PlayerAbilityState {
    public PlayerJumpState(PlayerStateMachine stateMachine, PlayerInputHandler inputHandler, Player player, PlayerData playerData, string animBoolName) : base(stateMachine, inputHandler, player, playerData, animBoolName) {
    }

    public override void Enter() {
        base.Enter();

        player.SetVelocityY(playerData.jumpHeight);
        inputHandler.UseJumpInput();

        //stateMachine.ChangeState(stateMachine.InAirState);
    }

    public override void Exit() {
        base.Exit();
    }

    public override void LogicUpdate() {
        base.LogicUpdate();

        if(!isGrounded) {
            stateMachine.ChangeState(stateMachine.InAirState);
        }
    }

    public override void PhysicsUpdate() {
        base.PhysicsUpdate();
    }
}
