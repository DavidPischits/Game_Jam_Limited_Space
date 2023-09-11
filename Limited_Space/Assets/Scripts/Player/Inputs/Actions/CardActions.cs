using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using System.Threading.Tasks;

public class CardActions : MonoBehaviour
{
    [SerializeField]Manager manager;


    public async void SelectRandom()
    {
        SelectRandomNpc();
    await Task.Delay(10);
        SelectRandomCard();
    }
    public void SelectRandomCard()
    {
        manager.currentCard = manager.currentNpc.cards[Random.Range(0, manager.cards.Count)];
    }

    public void SetCardToNull()
    {
        manager.currentCard = null;
    }

    public void SelectRandomNpc()
    {
        manager.currentNpc = manager.npcs[Random.Range(0, manager.npcs.Count)];
    }
}
