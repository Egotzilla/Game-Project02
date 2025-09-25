using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class PlayerStateMachine : StateMachine
{
    [field: SerializeField] public InputReader InputReader { get; private set; }
    [field: SerializeField] public CharacterController Controller { get; private set; }
    [field: SerializeField] public Animator Animator { get; private set; }
    [field: SerializeField] public Targeter Targeter { get; private set; }
    [field: SerializeField] public ForceReceiver ForceReceiver { get; private set; }
    [field: SerializeField] public WeaponDamage Weapon { get; private set; }
    [field: SerializeField] public float FreeLookMovementSpeed { get; private set; }
    [field: SerializeField] public float TargetingMovementSpeed { get; private set; }
    [field: SerializeField] public float RotationDamping { get; private set; }
    [field: SerializeField] public Attack[] Attacks { get; private set; }
    [field: SerializeField] public float JumpForce { get; private set; } = 7f;

    public Transform MainCameraTransform { get; private set; }
    public float VerticalVelocity { get; set; }

    private void Start()
    {
        MainCameraTransform = Camera.main.transform;

        // Subscribe to jump event
        InputReader.JumpEvent += HandleJump;

        SwitchState(new PlayerFreeLookState(this));
    }

    private void OnDestroy()
    {
        // Unsubscribe to prevent memory leaks
        if (InputReader != null)
        {
            InputReader.JumpEvent -= HandleJump;
        }
    }

    private void HandleJump()
    {
        // Handle jump logic - you can either:
        // 1. Call a method on the current state
        // 2. Switch to a jump state
        // 3. Set a flag that states can check
        
        // Example: Switch to a jump state (you'll need to create this)
        // SwitchState(new PlayerJumpState(this));
        
        // Or call a jump method on current state if it supports jumping
        Debug.Log("Jump input received!");
    }

}