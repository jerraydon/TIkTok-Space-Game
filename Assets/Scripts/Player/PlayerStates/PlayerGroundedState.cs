using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundedState : PlayerState {

    protected int xInput;
    protected bool jumpInput;

    protected bool isGrounded;

    public PlayerGroundedState(PlayerStateMachine stateMachine, PlayerInputHandler inputHandler, Player player, PlayerData playerData, string animBoolName) : base(stateMachine, inputHandler, player, playerData, animBoolName) {
    }

    public override void Enter() {
        base.Enter();

        inputHandler.UseJumpInput();
    }

    public override void Exit() {
        base.Exit();
    }

    public override void LogicUpdate() {
        base.LogicUpdate();

        xInput = (int)inputHandler.NormalizedMovement.x;
        jumpInput = inputHandler.JumpInput;

        isGrounded = player.CheckIfGrounded();

        if(!isGrounded) {
            stateMachine.ChangeState(stateMachine.InAirState);
        }
    }

    public override void PhysicsUpdate() {
        base.PhysicsUpdate();
    }
}
