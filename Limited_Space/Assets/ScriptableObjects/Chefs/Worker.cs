using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/new Chef")]
public class Worker : ScriptableObject
{
    [field: Header("General")]
    [field: SerializeField]public string messsage { get; private set; }

}
