using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/PlayerCards/new DefensiveCard")]
public class DefensiveCard : PlayerCard
{
    [field: Header("Factors")]


    [field: SerializeField]
    public override float DoorLockFactor { get; set; }

    [field: SerializeField]
    public override float ApFactor { get; set; }
}
