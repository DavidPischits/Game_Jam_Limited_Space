using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/new Card")]

public class Card : ScriptableObject
{
    public string answerYes;
    public string answerNo;
    public float value;
    public string dialogue;
    public Sprite sprite; 
}
