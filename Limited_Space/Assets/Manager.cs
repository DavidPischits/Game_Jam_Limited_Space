using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public List<Npc> npcs = new List<Npc>();
    public List<Card> cards = new List<Card>(); 
    public List<Card> seenCards = new List<Card>();
    public List<Npc> seenNpcs = new List<Npc>();
    public Npc currentNpc;
    public Card currentCard;


    async void Start()
    {
        SelectRandomNpc();
        SelectRandomCardNPC();

    }

    public void SelectRandomNpc()
    {
        currentNpc = npcs[Random.Range(0, npcs.Count)];
    }

    public void SelectRandomCardNPC()
    {
        currentCard = currentNpc.cards[Random.Range(0, currentNpc.cards.Count)];
    }

    public void MoveCardAway()
    {
        cards.Remove(currentCard);
        seenCards.Add(currentCard);
    }
    public void MoveNpcAway()
    {
        npcs.Remove(currentNpc);
        seenNpcs.Add(currentNpc);
    }



}
