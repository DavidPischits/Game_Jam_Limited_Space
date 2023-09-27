using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/new Stats")]
public class Stats : ScriptableObject
{
    [field: SerializeField] public int Reputation { get; set; }
    [field: SerializeField] public int Food { get;  set; }
    [field: SerializeField] public float Time { get;  set; }
    [field: SerializeField] public int Money { get;  set; }
    [field: SerializeField] public int Productivity { get;  set; }
}
