using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization.Json;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using System;
using static MouseActions;
using static ObjectSystem;
using static DeskCheck; 
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine.XR;

public class DesireSystem : MonoBehaviour
{
    public event Action OnWrongObject;
    [SerializeField] ChefManager chefManager;
    [SerializeField] AppManager appManager;
    [SerializeField] PlayerStats playerStats;
    [SerializeField]RuleManager ruleManager;

[SerializeField]    State state = State.good;



    public void CompareLists()
    {

        
            foreach(Applicant app in appManager.acceptedApps)
            {
                foreach(Property rule in ruleManager.positiveRules)
                    if (app.properties.Contains(rule))
                    {
                        Debug.Log("Yes, we needed " + rule.name);
                    }
            }

        foreach (Applicant app in appManager.acceptedApps)
        {
            foreach (Property rule in ruleManager.negativeRules)
                if (app.properties.Contains(rule))
                {
                    Debug.Log("No, we didn´t need " + rule.name);
                }
        }


    }

    enum State
    {
        good,
        noWork
    }

    void SwitchState(State newState)
    {
        if (state == newState) return; 
        
        
            switch(state)
            {
                case State.good: state = newState;
                    break;
                case State.noWork: OnWrongObject?.Invoke();
                    state = newState; 
                    break;
            }

        
    }

    public void Clear()
    {

    }
    public void Compare()
    {
       
       if(ruleManager.workObject != null)
        {
            WorkPass();
        }

    }

    public void WorkPass()
    {
        
        if (appManager.acceptedApps.Contains(appManager.currentApp))
        {
            if(appManager.currentApp.workObject == null)
            {
                Debug.Log("Why did you accepted someone without a workpass? ");
            }

            else
            {
                if(appManager.currentApp.workObject.type == ruleManager.ruleWorkType)
                {
                    Debug.Log("Great!");
                }

                else
                {
                    Debug.Log("Wrong passType!");
                }
            }
        }

        else if(appManager.deniedApps.Contains(appManager.currentApp))
        {
            if(appManager.currentApp.workObject == null)
            {
                Debug.Log("Good, cause he had no workpass");
            }
            
            else
            {
                if (appManager.currentApp.workObject.type == ruleManager.ruleWorkType)
                {
                    Debug.Log("He even had the right pass!");
                }

                else
                {
                    Debug.Log("Good, cause he had the wrong type");
                }
            }

        }


       
    }

    void DebugWorkPass()
    {
        Debug.Log("No workPass");
    }


   
    public void CompareNormalApp()
    {

        if(appManager.currentApp.workObject != null)
        {
            if(appManager.currentApp.workObject.type == ruleManager.ruleWorkType)
            {
            }

            else
            {
            }
        }
    }

    void OnEnable()
    {
        
    }


}

