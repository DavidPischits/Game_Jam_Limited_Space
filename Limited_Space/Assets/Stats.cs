using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    [field: SerializeField] public int Reputation { get; private set; }
    [field: SerializeField] public int Food { get; private set; }
    [field: SerializeField] public float Time { get; private set; }
    [field: SerializeField] public int Money { get ; private set; }
    [field: SerializeField] public int Productivity { get; private set; }


    public void LowerFood()
    {
        Food -= 1;
    }
}
