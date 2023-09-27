using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Prop/ObjectProp/WorkObject")]

public class WorkObject : ObjectProp
{
    public override string RuleMessage => "Every Applicant needs a valid work ID";
    public override string NegativeRuleMessage => "No workIDs allowed";
    public string FirstName;
    public string LastName;
    public WorkObjectType type = WorkObjectType.conform;

    public WorkObject(string first, string last, WorkObjectType newType)
    {
        FirstName = first;
        LastName = last;
        type = newType;
    }
}


public enum WorkObjectType
{
    conform,
    wrong,
}
