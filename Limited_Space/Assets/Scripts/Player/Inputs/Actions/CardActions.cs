using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using System.Threading.Tasks;
using System;

public class CardActions : MonoBehaviour
{
    [SerializeField]Manager manager;
    public event Action OnNewCard;
    public event Action OnFirst;
    [SerializeField] CardDisplay display;

    private void Start()
    {
        OnFirst?.Invoke();
    }

    public void TryNewCard()
    {
        if(CardSM.cardState == CardSM.CardState.Left)
        {
            OnNewCard?.Invoke();
        }
    }
    
    void OnEnable()
    {
        OnFirst += manager.SelectRandomNpc;
        OnFirst += manager.SelectRandomCardNPC;

        OnNewCard += manager.MoveCardAway;
        OnNewCard += manager.SelectRandomCardNPC;
        OnNewCard += display.SetToCurrent;
    }
}
