using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/new Application")]

public class App : ScriptableObject
{
    [field: Header("General")]
    [field: SerializeField] public string _Name { get ; private set; }
    [field : SerializeField] public Sex sex { get; private set; }
    [field: SerializeField] public Sprite CharSprite { get; private set; }

    [field: Header("Birthday")]
    [field: SerializeField] public int DayOfBirth { get; private set; }
    [field: SerializeField] public int MonthOfBirth { get; private set; }
    [field: SerializeField] public int YearOfBirth { get; private set; }

    [field: Header("Important")]
    [field: SerializeField] public string History { get; private set; }
    [field: SerializeField] public string Education { get; private set; }
    [field: SerializeField] public string Knowledge { get; private set; }
    [field: SerializeField] public string Interests { get; private set; }

}

public enum Country
{
    France,
    Germany,
    Italia,
    Arabia,
}
public enum Sex
{
    none,
    male,
    female
}
