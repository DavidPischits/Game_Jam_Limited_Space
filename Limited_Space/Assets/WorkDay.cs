using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/new WorkDay")]
public class WorkDay : ScriptableObject
{
    [field: SerializeField] public List <Property> positiveRules = new List <Property>();
    [field: SerializeField] public List<Property> negativeRules = new List<Property>();
    [field: SerializeField] public AppList appList { get; private set; }
}
