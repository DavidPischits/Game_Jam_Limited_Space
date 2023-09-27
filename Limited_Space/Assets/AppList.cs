using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/new AppList")]
public class AppList : ScriptableObject
{
    [field: SerializeField]public List<Applicant> list { get; private set; } = new List<Applicant>();
}
