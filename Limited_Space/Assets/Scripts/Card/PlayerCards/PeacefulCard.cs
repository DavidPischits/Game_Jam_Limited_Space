using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/PlayerCards/new PeacefulCard")]
public class PeacefulCard : PlayerCard

{
  
    [field: Header("Factors")]

    [field: SerializeField]
    public override float SanityFactor { get; set; }
    [field: SerializeField]
    public override float ChatinessFactor { get; set; }
}
