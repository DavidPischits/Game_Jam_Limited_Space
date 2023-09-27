using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static DeskCheck;
using static ObjectSystem;

public class RuleManager : MonoBehaviour
{
    public List<Property> positiveRules = new List<Property>();
    public List<Property> negativeRules = new List<Property>();
    public WorkObjectType ruleWorkType = WorkObjectType.conform;
    [SerializeField] public WorkObject workObject;
    [SerializeField] public ApplicationObject applicationObject;
    [SerializeField] DesireSystem desireSystem;



    public void Clean()
    {
        OnListEmpty -= desireSystem.WorkPass;

    }
    public void Check()
    {
        //if (workObject != null)
        //{
        //    OnListEmpty += desireSystem.CompareNormalWorkPass;
        //}

        //else if (workObject == null)
        //{
        //    OnListEmpty -= desireSystem.CompareNormalWorkPass;
        //}

        ////if(applicationObject == null)
        ////{
        ////    OnListEmpty -= desireSystem.CompareNormalApp;
        ////}

        ////else if(applicationObject != null) 
        ////{
        ////    OnListEmpty += desireSystem.CompareNormalApp;
        ////}

    }
}
