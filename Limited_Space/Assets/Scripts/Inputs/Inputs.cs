using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Inputs : MonoBehaviour
{
    Controls controls;

    InputAction moveInputAction;
    MovementActions movementActions;
    AttackActions attackActions;
    [SerializeField] Vector2 moveInput;
    private event Action<Vector2> OnMove;

    
    void Awake()
    {
        controls = new Controls();
        movementActions = GameObject.FindObjectOfType<MovementActions>().GetComponent<MovementActions>();
        moveInputAction = controls.Movement.Move;

       
    }

    void Start()
    {
        InputEnabling.EnableAction(moveInputAction); 
        
    }
    void Update()
    {
        
        OnMove.Invoke(moveInputAction.ReadValue<Vector2>());
    }

    void OnEnable()
    {
        OnMove += movementActions.Move;
    }

    void OnDisable()
    {
        OnMove -= movementActions.Move;
    }
}
