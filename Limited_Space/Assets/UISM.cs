using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISM : StateMachine
{

    public static UIState uiState { get; private set; }
    [SerializeField] AppData appData;

    void Awake()
    {
        appData = GameObject.FindObjectOfType<AppData>().GetComponent<AppData>();
    }
    public enum UIState
    {
        Cold,
        App
    }


    public  void ChangeState(UIState newState)
    {
        if (CheckIfAlready(newState)) { return; }

        else
        {
            switch(newState)
            {
                case UIState.Cold:
                    break;
                case UIState.App: appData.ToogleApp(true);
                    break;
            }
        }
    }

    public  bool CheckIfAlready(UIState state)
    {
        if (uiState == state) { return true; }

        else
            return false;
    }


}

