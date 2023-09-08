using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    [SerializeField]Card card;
    [SerializeField] Image image;
    [SerializeField] TextMeshProUGUI cornerTm;
    [SerializeField] TextMeshProUGUI nameTm;



    public void DisplayAggressionCard(AggressionCard aggressionCard)
    {
        cornerTm.text = aggressionCard.ApFactor.ToString();
        nameTm.text = aggressionCard.name.ToString();
        image.sprite = aggressionCard.cardSprite;

    }
}
