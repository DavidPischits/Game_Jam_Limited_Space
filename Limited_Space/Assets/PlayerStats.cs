using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public Stats playerStats;

    [field: SerializeField] public int Reputation { get; private set; }
    [field: SerializeField] public int Food { get; private set; }
    [field: SerializeField] public float Time { get; private set; }
    [field: SerializeField] public int Money { get; private set; }
    [field: SerializeField] public float Productivity { get; private set; }


    void Start()
    {
        DefineValues();
    }

    public void ChangeProductivity(float amount)
    {
        Productivity += amount;
    }
    public void DefineValues()
    {
        Reputation = playerStats.Reputation;
        Food = playerStats.Food;  
        Time = playerStats.Time;
        Money = playerStats.Money;
        Productivity = playerStats.Productivity;

    }
    public void LooseFood(int amount)
    {
        Food -= amount;
    }
}
