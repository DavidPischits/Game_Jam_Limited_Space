using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Unity.VisualScripting;

public class MessageObjectSM : ObjectSM
{
    public State state = State.Cold;

    public override event Action OnDropped;
    event Action<UISM> OnDroppedOnDesk;
    AppDisplay display;
    public CinemachineVirtualCamera virtualCamera;


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
                break;
            case State.DroppedOnDesk:
                break;
            case State.Dropped:
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
                    cmControl.ChangeState(CinemachineControl.CmState.zoom); 
                    state = newState;
                    break;
                case State.DroppedOnDesk:
                    cmControl.ChangeState(CinemachineControl.CmState.normal);
                    OnDropped?.Invoke();

                    state = newState;
                    break;
                case State.Dropped:
                    OnDropped?.Invoke();

                    cmControl.ChangeState(CinemachineControl.CmState.normal);




                    state = newState;
                    break;

            }

        }


    }

    public override void OnEnable()
    {
        OnDropped += objManager.SetToNull;




    }

    void OnDisable()
    {
        OnDropped -= objectTransform.TransformToSlot;
        OnDropped -= objManager.SetToNull;
    }
}
