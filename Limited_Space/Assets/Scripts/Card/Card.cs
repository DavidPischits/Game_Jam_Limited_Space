using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/new Card")]

public class Card : ScriptableObject
{
    public float cost;
    public float restoreSanity;
    public float actionPoints;
    public Sprite cardSprite;


    void Awake()
    {

    }

}
