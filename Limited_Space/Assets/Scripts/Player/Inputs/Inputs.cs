using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Inputs : MonoBehaviour
{
    Controls controls;

    public static InputAction clickAction;
    [SerializeField]CardSM cardSm;

    
    void Awake()
    {
        controls = new Controls();

        clickAction = controls.CardInteraction.clickAction;
       
    }

    void Start()
    {
        InputEnabling.EnableAction(clickAction);
    }


    void OnEnable()
    {
        clickAction.performed += _ => cardSm.ChangeState(CardSM.CardState.CardAway);
    }

    void OnDisable()
    {
    }
}
