using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DenyButton : But
{
    public ButtonState ButtonState { get; private set; }

    public  event Action OnDenyPressed;
    ButtonState state;
    



    public override void ChangeButtonState(ButtonState newState)
    {

       
            switch (newState)
            {
                case ButtonState.cold:
                    state = newState;
                    break;
                case ButtonState.pressed:
                    OnDenyPressed?.Invoke(); Debug.Log("denyButton pressed");
                    state = newState;
                    break;
            }

        
    }

    public override void OnEnable()
    {
        OnDenyPressed += deskCheck.PressedTrue;
        OnDenyPressed += appManager.MoveToDenied;
    }
}
