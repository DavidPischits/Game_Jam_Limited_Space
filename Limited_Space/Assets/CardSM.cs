using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using static DeckSM;

public class CardSM : MonoBehaviour
{
    public static event Action <string> OnLeft;
    public static event Action<string> OnRight;
    public event Action OnNewCard;
    public CardActions cardActions;
    [SerializeField] CardDisplay cardDisplay;
    [SerializeField] AudioManager audioManager;
    [SerializeField] AudioClip click;
    [SerializeField]Manager manager;
    [SerializeField] DisplayActions displayActions;
    [SerializeField] CardDisplay display;
    [SerializeField] CardTransform cardTransform;

    [SerializeField]CardState cardState = CardState.Cold;

    public enum CardState
    {
        Cold,
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


    public async void ChangeState(CardState newState)
    {
        if(newState == CardState.Left)
        {
            OnLeft?.Invoke(manager.currentCard.answerYes);
            cardState = newState;
            audioManager.PlayAudio(click);
        }

        else if(newState == CardState.Right)
        {
            OnRight?.Invoke(manager.currentCard.answerNo);
            cardState = newState;
        }

    }

    public void CardAway()
    {
        if (Leaned())
        { 
            cardTransform.RotateCardAroundSelf();
            OnNewCard?.Invoke();
        }
    }

    void OnEnable()
    {
        OnLeft += _ => cardTransform.RotateCardLeft();
        OnLeft += cardDisplay.DisplayAnswer;
        OnLeft += _ => audioManager.PlayAudio(click);

        OnRight += _ => cardTransform.RotateCardRight();
        OnRight += cardDisplay.DisplayAnswer;
        OnRight += _ => audioManager.PlayAudio(click);


        OnNewCard += manager.MoveCardAway;
        OnNewCard += manager.SelectRandomNpc;
        OnNewCard += manager.SelectRandomCardNPC;
        OnNewCard += displayActions.SetToCurrent;

    }
}
