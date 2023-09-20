using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/new Chef")]
public class Chef : ScriptableObject
{
    [field: SerializeField] public Sex desiredSex { get; private set; }
    [field: SerializeField] public Sex unDesiredSex { get; private set; }
}
