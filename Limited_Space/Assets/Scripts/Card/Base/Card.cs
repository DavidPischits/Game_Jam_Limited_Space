using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class Card : ScriptableObject
{
    [field: Header("General")]
    [field: SerializeField]
    public virtual string _name{get; set;}
    [field: SerializeField]
    public virtual Sprite cardSprite { get; set;}

    [field: Header("Factors")]
    public virtual float AggressionFactor { get; set;}
    public virtual float ApFactor { get; set; }
    public virtual float NpcAggressionFactor { get; set; }
    public virtual float ChatinessFactor { get; set; }
    public virtual float SanityFactor { get; set; }
    public virtual float DoorLockFactor { get; set; }

}
