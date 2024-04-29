using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceDogState {

    protected SpaceDogStateMachine stateMachine;
    protected SpaceDog spaceDog;
    protected string animBoolName;

    public SpaceDogState(SpaceDogStateMachine stateMachine, SpaceDog spaceDog, string animBoolName) {
        this.stateMachine = stateMachine;
        this.spaceDog = spaceDog;
        this.animBoolName = animBoolName;
    }

    public virtual void Enter() {
        spaceDog.Anim.SetBool(animBoolName, true);
    }

    public virtual void Exit() {
        spaceDog.Anim.SetBool(animBoolName, false);
    }

    public virtual void LogicUpdate() { }

    public virtual void PhysicsUpdate() { }
}
