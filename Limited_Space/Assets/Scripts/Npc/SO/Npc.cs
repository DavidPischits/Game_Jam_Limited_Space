using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/new Npc")]
public class Npc : ScriptableObject
{ 
    public string name;
    public string Job;
    public string text;
    public Sprite npcSprite;
}