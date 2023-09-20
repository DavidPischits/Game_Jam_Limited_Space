using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using static MouseSM;

public class Inputs : MonoBehaviour
{
    Controls controls;
    public static InputAction clickAction;
    [SerializeField] Camera mainCamera;
    [SerializeField] MouseActions mouseActions;
    public Vector2 mousePos;
    
    void Awake()
    {
        controls = new Controls();

        clickAction = controls.CardInteraction.clickAction;
       
    }

    void Start()
    {
        InputEnabling.EnableAction(clickAction);
    }


    public void Update()
    {

        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            mouseActions.SetPaper();
        }

        else if(Mouse.current.leftButton.isPressed)
        {
            mouseActions.Move();
        }

        else if(Mouse.current.leftButton.wasReleasedThisFrame)
        {
            mouseActions.CheckUI();
        }

        

    }

    void OnEnable()
    {

    }



}
