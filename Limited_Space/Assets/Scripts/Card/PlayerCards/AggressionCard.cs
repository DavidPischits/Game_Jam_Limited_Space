using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/PlayerCards/new AggressionCard")]
public class AggressionCard : PlayerCard
{
    [field: Header("Factors")]

    [field: SerializeField]
    public override float AggressionFactor { get; set; }
    [field: SerializeField]
    public override float ApFactor { get; set;}
    [field: SerializeField]
    public override float NpcAggressionFactor { get; set;}
}
