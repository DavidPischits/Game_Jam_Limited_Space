using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class But : MonoBehaviour
{
   public virtual void ChangeButtonState(ButtonState newButtonState)
    {

    }
}

public enum ButtonState
{
    cold,
    pressed
}
