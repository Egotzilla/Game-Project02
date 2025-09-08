using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class PlayerBaseState : State
{
    protected PlayerStateMachine stateMachine;

    public PlayerBaseState(PlayerStateMachine stateMachine)

    {
        this.stateMachine = stateMachine;

    }
}
