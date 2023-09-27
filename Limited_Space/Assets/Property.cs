using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Property : ScriptableObject
{
    [field: SerializeField]public virtual string RuleMessage { get; private set; }
    [field: SerializeField] public virtual string NegativeRuleMessage { get; private set; }
    [field: SerializeField]public virtual string DisplayMessage { get; private set; }
}
