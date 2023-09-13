using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/new Npc")]

public class Npc : ScriptableObject
{
    public List<Card> cards = new List<Card>();
    public string _name;
}
