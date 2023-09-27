using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class But :  MonoBehaviour
{
    [SerializeField] public DesireSystem desireSystem;
    [SerializeField] public AppManager appManager;
    [SerializeField] public AppDisplay display;
    [SerializeField] public RuleManager ruleManager;
    [SerializeField] public DeskCheck deskCheck;

    public virtual void Awake()
    {
        display = GameObject.FindObjectOfType<AppDisplay>().GetComponent<AppDisplay>();
        desireSystem = GameObject.FindObjectOfType<DesireSystem>().GetComponent<DesireSystem>();
        appManager = GameObject.FindObjectOfType<AppManager>().GetComponent<AppManager>();
        ruleManager = GameObject.FindObjectOfType<RuleManager>().GetComponent<RuleManager>();
        deskCheck = GameObject.FindObjectOfType<DeskCheck>().GetComponent<DeskCheck>();
    }
    public virtual void ChangeButtonState(ButtonState newButtonState)
    {

    }

    public virtual void OnEnable()
    {
       
    }


}

public enum ButtonState
{
    cold,
    pressed
}

