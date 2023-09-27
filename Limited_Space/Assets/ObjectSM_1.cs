using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.XR;

public class PaperObjectSM : ObjectSM
{
    public State state = State.Cold;

    public override event Action OnDropped;
    event Action<UISM>OnDroppedOnDesk;
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
                objectTransform.TransformToSlot();
                break;
            case State.Picked: objectTransform.TransformWithMouse();
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
                case State.Cold: ;
                    state = newState;
                     break;
                case State.Picked:
                    state = newState;
                    break;
                case State.DroppedOnDesk:
                    gameObject.SetActive(false);
                    OnDroppedOnDesk?.Invoke(null);
                state = newState;
                    break;
                case State.Dropped:   
                     
                    OnDropped?.Invoke();
                state = newState;
                    break;

            }

        }
        
        
    }

    

    public override void OnEnable()
    {
        OnDropped += objectTransform.TransformToSlot;
        OnDropped += objManager.SetToNull;


        OnDroppedOnDesk += _ => objManager.SetToNull();
        OnDroppedOnDesk += _ => appManager.NewCurrentApp();
        OnDroppedOnDesk += _ => objSystem.EnableObjects();
        OnDroppedOnDesk += _ => deskCheck.SetList();

        
    }

    void OnDisable()
    {
        OnDroppedOnDesk -= _ => appManager.NewCurrentApp();
        OnDroppedOnDesk -= _ => objSystem.EnableObjects();

        OnDropped -= objectTransform.TransformToSlot;
        OnDropped -= objManager.SetToNull;
    }
}


