using System;
using System.Collections;
using System.Collections.Generic;
using System.Resources;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectSM : StateMachine
{
    [SerializeField] public ObjectProp objectProp;
    [SerializeField] public ObjectManager objManager;
    [SerializeField] public ObjectTransform objectTransform;
    [SerializeField] GameObject app;
    [SerializeField] public UISM ui;
    [SerializeField] public ObjectSystem objSystem;
    [SerializeField] public CinemachineControl cmControl;
    [SerializeField] public RuleManager ruleManager;
    [SerializeField] public AppManager appManager;
    public DesireSystem desireSystem;
    public DeskCheck deskCheck;
    public virtual event Action OnDropped;


    public virtual void Awake()
    {
        ui = GameObject.FindObjectOfType<UISM>().GetComponent<UISM>();
        
        objSystem = GameObject.FindObjectOfType<ObjectSystem>().GetComponent<ObjectSystem>();
        objManager = GameObject.FindObjectOfType<ObjectManager>().GetComponent<ObjectManager>();
        cmControl = GameObject.FindObjectOfType<CinemachineControl>().GetComponent<CinemachineControl>();
        ruleManager = GameObject.FindObjectOfType<RuleManager>().GetComponent<RuleManager>();
        appManager = GameObject.FindObjectOfType<AppManager>().GetComponent<AppManager>();
        deskCheck =GameObject.FindObjectOfType<DeskCheck>().GetComponent<DeskCheck>();
        desireSystem = GameObject.FindObjectOfType<DesireSystem>().GetComponent<DesireSystem>();

        if (gameObject.GetComponent<ObjectTransform>() == null)
        {
            gameObject.AddComponent<ObjectTransform>();
        }

        else
        {
            objectTransform = gameObject.GetComponent<ObjectTransform>();
        }
    }

    public virtual void ChangeState(State newState)
    {

    }

    
  


    public virtual void OnEnable()
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


