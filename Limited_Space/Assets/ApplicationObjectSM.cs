using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.UI;

public class ApplicationObjectSM : ObjectSM
{
    public State state = State.Cold;
    public override event Action OnDropped;
    event Action<UISM> OnDroppedOnDesk;
    AppDisplay display;


    public override void Awake()
    {
        base.Awake();
    }


    public void Update()
    {
        switch (state)
        {
            case State.Cold:
                break;
            case State.Picked:
                objectTransform.TransformWithMouse();
                break;
            case State.DroppedOnDesk:

                break;
            case State.Dropped:
                objManager.SetToNull();


                break;

        }
    }

    public override void ChangeState(State newState)
    {
        if (state == newState) { return; }

        else
        {
            switch (newState)
            {
                case State.Cold:
                    state = newState;
                    break;
                case State.Picked:
                    state = newState;
                    break;
                case State.DroppedOnDesk:
                    objManager.SetToNull();
                    state = newState;
                    break;
                case State.Dropped:
                    objManager.SetToNull();
                    state = newState;
                    break;

            }

        }


    }
}
