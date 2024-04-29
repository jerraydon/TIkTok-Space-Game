using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceDogStateMachine : MonoBehaviour {

    private SpaceDog spaceDog;

    public SpaceDogState CurrentState { get; private set; }

    public SpaceDogIdleState IdleState { get; private set; }

    private void Start() {
        Init(IdleState);
    }

    private void Update() {
        CurrentState.LogicUpdate();
    }

    private void FixedUpdate() {
        CurrentState.PhysicsUpdate();
    }

    private void Init(SpaceDogState state) {
        CurrentState = state;
        CurrentState.Enter();
    }

    public void ChangeState(SpaceDogState newState) {
        CurrentState.Exit();
        CurrentState = newState;
        CurrentState.Enter();
    }

}
