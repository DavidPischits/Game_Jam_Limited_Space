using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEngine;
using System;
public class AcceptButton : But
{
    public event Action OnPressed;
    ButtonState state;
    [SerializeField] DesireSystem desireSystem;

    public override void ChangeButtonState(ButtonState newState)
    {
        if (state == newState) { return; }

        else
        {
            switch(newState)
            {
                case ButtonState.cold: state = newState;
                    break;
                case ButtonState.pressed: OnPressed?.Invoke();
                    state = newState;
                    break;
            }

        }
    }

    void OnEnable()
    {
        OnPressed += desireSystem.CheckDesire;
        OnPressed += desireSystem.CheckNegativeDesires;
    }
}
