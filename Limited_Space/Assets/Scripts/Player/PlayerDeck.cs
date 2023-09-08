using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    [SerializeField] public  CardDisplay cardDefS;
    [SerializeField] public  CardDisplay cardDef2S;
    [SerializeField] public  CardDisplay cardDef3S;

    [SerializeField] public static CardDisplay cardDef;
    [SerializeField] public static CardDisplay cardDef2;
    [SerializeField] public static CardDisplay cardDef3;
    [SerializeField] CardManager cardManager;

    void Awake()
    {
        cardDef = cardDefS;
        cardDef2 = cardDef2S;
        cardDef3 = cardDef3S;
    }

    void Update()
    {
        cardDef.DisplayAggressionCard(cardManager.AggressionCards[Random.Range(0, cardManager.AggressionCards.Count)]);
    }


}
