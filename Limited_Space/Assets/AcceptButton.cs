using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEngine;
using System;
public class AcceptButton : But
{
    public event Action OnAcceptPressed;
    [SerializeField] ButtonState state;

    public override void ChangeButtonState(ButtonState newState)
    {
        //if (state == newState) { return; }

            switch(newState)
            {
                case ButtonState.cold: state = newState;
                    break;
                case ButtonState.pressed: OnAcceptPressed?.Invoke();Debug.Log("pressed");
                    state = newState;
                    break;
            }

        
    }

    public override void OnEnable()
    {
        OnAcceptPressed += appManager.MoveToAccepted;
        OnAcceptPressed += deskCheck.PressedTrue;
    }
}
