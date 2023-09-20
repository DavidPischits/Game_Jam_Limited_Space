using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using DG.Tweening;

 

public class MouseSM : StateMachine
{

    [SerializeField] Camera mainCamera;
    public static MouseState mouseState { get; private set; }
    [SerializeField] ObjectManager objectManager;

    public enum MouseState
    {
        Cold,
        PickUp,
        Dropped,
        DropOnDesk,
    }

    public void Update()
    {
        switch(mouseState)
        {
            case MouseState.Cold:
                break;
            case MouseState.PickUp: 
                break;
            case MouseState.DropOnDesk:
                break;
        }
    }

    public void ChangeMouseState(MouseState newState)
    {
        if (CheckIfAlready(newState)) { return; }

        else
        {
            switch(newState)
            {
                case MouseState.Cold: 
                    mouseState = newState;
                    break;
                case MouseState.PickUp: Debug.Log("PickUp");
                    mouseState = newState;
                    break;
                case MouseState.Dropped:
                        mouseState = newState;
                        break;
                case MouseState.DropOnDesk: 
                    mouseState = newState;

                    break;
               
            }
        }
    }

    public bool CheckIfAlready(MouseState state)
    {
        if (mouseState == state) { return true; }

        else
            return false;
    }

  


}
