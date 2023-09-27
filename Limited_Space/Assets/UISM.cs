using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISM : StateMachine
{

    public static UIState state { get; private set; }
    [SerializeField] AppData appData;

    void Awake()
    {
        appData = GameObject.FindObjectOfType<AppData>().GetComponent<AppData>();
    }
    public enum UIState
    {
        Cold,
        App,
        End
    }


    public  void ChangeState(UIState newState)
    {
        if (CheckIfAlready(newState)) { return; }

        else
        {
            switch(newState)
            {
                case UIState.Cold:
                    state = newState;
                    break;
                case UIState.App: appData.ToogleApp(true);
                    state = newState;
                    break;
                case UIState.End: appData.ToogleWorkCanvas(false);
                                  
                    state = newState;
                    break;
            }
        }
    }

    public  bool CheckIfAlready(UIState state)
    {
        if (UISM.state == state) { return true; }

        else
            return false;
    }


}

