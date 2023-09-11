using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DeckSM;

public class CardSM : MonoBehaviour
{
    public static event Action <string> OnLeft;
    public static event Action<string> OnRight;
    public event Action OnNewCard;
    public CardActions cardActions;
    [SerializeField] CardDisplay cardDisplay;
    [SerializeField]Manager manager;
    [SerializeField] CardDisplay display;
    [SerializeField] CardTransform cardTransform;

    [SerializeField]CardState cardState = CardState.Cold;

    public enum CardState
    {
        Cold,
        NewCard,
        Left,
        Right,
        CardAway,
    }

    bool Leaned()
    {
        if(cardState == CardState.Left)
        {
            return true;
        }

        else if(cardState == CardState.Right)
        {
            return true;
        }

    return false;
    }


    public void ChangeState(CardState newState)
    {
        if(newState == CardState.Left)
        {
            OnLeft?.Invoke(manager.currentCard.answerYes);
            cardState = newState;
        }

        else if(newState == CardState.Right)
        {
            OnRight?.Invoke(manager.currentCard.answerNo);
            cardState = newState;
        }

        else if (newState == CardState.NewCard)
        {
            OnNewCard?.Invoke();
            cardState = newState;
            display.Display(manager.currentNpc._name, manager.currentCard.sprite, manager.currentCard.dialogue);
        }

        else if (newState == CardState.CardAway)
        {
            if(Leaned())
            {
                cardTransform.RotateCardAroundSelf();
                cardState = newState;
            }

           
        }
    }

    void OnEnable()
    {
        OnLeft += _ => cardTransform.RotateCardLeft();
        OnLeft += cardDisplay.DisplayAnswer;

        OnRight += _ => cardTransform.RotateCardRight();
        OnRight += cardDisplay.DisplayAnswer;

        OnNewCard += cardActions.SelectRandom;
    }
}
