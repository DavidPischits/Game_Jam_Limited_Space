using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDefinition : MonoBehaviour
{
    [SerializeField]Card card;
    public float cost;
    public float restoreSanity;
    public float actionPoints;
    public Image cardImage;
    public TextMeshProUGUI mana;
    

    void Awake()
    {
        ChangeSanity();
    }
    void ChangeSanity()
    {
        restoreSanity = card.restoreSanity;
        cost = card.cost;
        actionPoints = card.actionPoints;
      
        cardImage.sprite = card.cardSprite;
        mana.text = card.cost.ToString();
    }
}
