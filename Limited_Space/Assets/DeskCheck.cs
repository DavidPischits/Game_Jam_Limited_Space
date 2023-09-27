using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System;
using TMPro;
using DG.Tweening.Core.Easing;

public class DeskCheck : MonoBehaviour
{
    public static event Action OnListEmpty;
    public List <ObjectProp> props = new List <ObjectProp>();
    public AppDisplay display;
    [SerializeField] RuleManager ruleManager;
    [SerializeField] AppManager appManager;
    DesireSystem desireSystem;
    [SerializeField] ObjectSystem objectSystem;
    public bool pressed = false;
    public bool denied  = false;

    void Awake()
    {
        desireSystem = GameObject.FindObjectOfType<DesireSystem>().GetComponent<DesireSystem>();
    }

    void Start()
    {
        //var app = appManager.currentApp;
        
        //if(app.workObject != null)
        //    props.Add(appManager.currentApp.workObject);

        //if(app.application != null)
        //    props.Add (app.application);

    }

    void Update()
    {
        foreach(var prop in props)

        {
            if(prop == null)
            {
                props.Remove(prop);
            }
        }

    }


    public void PressedTrue()
    {
        pressed = true;
    }

    public void PressedFalse()
    {
        pressed = false;
    }

    public void SetList()
    {
        if(appManager.currentApp.workObject != null)
        {
            props.Add(appManager.currentApp.workObject);

        }

        if(appManager.currentApp.application != null)
        {
            props.Add(appManager.currentApp.application); 
        }
    }

    public void CheckDeskState()
    {

        if (props.Count <=  0 && pressed == true)
        {
            OnListEmpty?.Invoke();
        }
    }

    void OnEnable()
    {
        OnListEmpty += objectSystem.DisableObjects;
        OnListEmpty += objectSystem.EnablePaperObject;
        OnListEmpty += desireSystem.Compare;
        
    }



    public void Add(ObjectProp objectProp)
    {
        if (props.Contains(objectProp) == false)
        {
            props.Add (objectProp);

        }
    }   
    public void Remove(ObjectProp objectProp)
    {
        if (props.Contains(objectProp))
        {
            props.Remove(objectProp);  
            CheckDeskState();
        }
    }
}
