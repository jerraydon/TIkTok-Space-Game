using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState {

    protected PlayerStateMachine stateMachine;
    protected PlayerInputHandler inputHandler;
    protected Player player;
    protected PlayerData playerData;
    protected string animBoolName;

    public PlayerState(PlayerStateMachine stateMachine, PlayerInputHandler inputHandler, Player player, PlayerData playerData, string animBoolName) {
        this.stateMachine = stateMachine;
        this.inputHandler = inputHandler;
        this.player = player;
        this.playerData = playerData;
        this.animBoolName = animBoolName;
    }

    public virtual void Enter() {
        player.Anim.SetBool(animBoolName, true);

        Debug.Log(animBoolName);
    }

    public virtual void Exit() {
        player.Anim.SetBool(animBoolName, false);
    }

    public virtual void LogicUpdate() { }

    public virtual void PhysicsUpdate() { }
}
