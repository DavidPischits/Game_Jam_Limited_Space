using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.XR;

public class PaperObjectSM : ObjectSM
{
    public State state = State.Cold;
    [SerializeField] ObjectManager objManager;
    [SerializeField] ObjectTransform objectTransform;
    [SerializeField] GameObject app;
    event Action OnDropped;
    event Action<UISM>OnDroppedOnDesk;
    [SerializeField] UISM ui;

 
    void Awake()
    {
        objectTransform = gameObject.GetComponent<ObjectTransform>();
        objManager = GameObject.FindObjectOfType<ObjectManager>().GetComponent<ObjectManager>();
    }
 

    public void Update()
    {
        switch (state)
        {
            case State.Cold:
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
                case State.Cold: 
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

    void OnEnable()
    {
        OnDropped += objectTransform.TransformToSlot;
        OnDropped += objManager.SetToNull;

        OnDroppedOnDesk += _ => ui.ChangeState(UISM.UIState.App);

        
    }

    void OnDisable()
    {
        OnDropped -= objectTransform.TransformToSlot;
        OnDropped -= objManager.SetToNull;
    }
}


