using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Prop/ObjectProp/ApplicationObject")]

public class ApplicationObject : ObjectProp
{
    public override string RuleMessage => "Every Applicant needs an application";
    public override string NegativeRuleMessage => "No applications allowed";
}
