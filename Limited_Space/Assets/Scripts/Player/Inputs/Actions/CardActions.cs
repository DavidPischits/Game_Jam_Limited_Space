using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using System.Threading.Tasks;

public class CardActions : MonoBehaviour
{
    [SerializeField]Manager manager;

 

    public void MoveCardAway()
    {
        manager.cards.Remove(manager.currentCard);
        manager.seenCards.Add(manager.currentCard);
    }
    public void MoveNpcAway()
    {
        manager.npcs.Remove(manager.currentNpc);
        manager.seenNpcs.Add(manager.currentNpc);
    }

    public void SelectRandomNpc()
    {
        manager.currentNpc = manager.npcs[Random.Range(0, manager.npcs.Count)];
    }
}
