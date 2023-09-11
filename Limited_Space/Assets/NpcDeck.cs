using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcDeck : MonoBehaviour
{
    [SerializeField]Card currentCard;


    public void ChangeCurrentCard(Card newCard)
    {
        currentCard = newCard;
    }
}
