using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class StateMachine : MonoBehaviour

    
{
    private State currentState;

    public void SwitchState(State newState) {
        currentState?.Exit();
        currentState = newState;
        currentState.Enter();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    currentState?.Tick(Time.deltaTime);
        
        
    }
}
