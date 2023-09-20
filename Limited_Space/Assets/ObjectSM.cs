using System.Collections;
using System.Collections.Generic;
using System.Resources;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectSM : StateMachine
{
    public virtual void ChangeState(State newState)
    {

    }

    
  



}

    public enum State
    {
        Cold,
        Picked,
        Dropped,
        DroppedOnDesk,
    }


