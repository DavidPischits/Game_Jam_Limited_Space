using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public List<Npc> npcs = new List<Npc>();
    public List<Card> cards = new List<Card>(); 
    List<Card> seenCards = new List<Card>();
    public Npc currentNpc;
    public Card currentCard;


    void Start()
    {
        SelectRandomNpc();
        SelectRandomCard();
    }
    public void SelectRandomNpc()
    {
        currentNpc = npcs[Random.Range(0, npcs.Count)];
    }

    public void SelectRandomCard()
    {
        currentCard = currentNpc.cards[Random.Range(0, cards.Count)];
    }



}
