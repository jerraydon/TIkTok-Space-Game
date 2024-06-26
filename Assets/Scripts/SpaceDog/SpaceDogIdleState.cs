using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceDogIdleState : SpaceDogState {

    public SpaceDogIdleState(SpaceDogStateMachine stateMachine, SpaceDog spaceDog, string animBoolName) : base(stateMachine, spaceDog, animBoolName) {
    }

    public override void Enter() {
        base.Enter();
    }

    public override void Exit() {
        base.Exit();
    }

    public override void LogicUpdate() {
        base.LogicUpdate();
    }

    public override void PhysicsUpdate() {
        base.PhysicsUpdate();
    }

}
