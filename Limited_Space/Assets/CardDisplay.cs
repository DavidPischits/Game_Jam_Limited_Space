using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class CardDisplay : MonoBehaviour
{
    [SerializeField] Image image;
    [SerializeField] TextMeshProUGUI _name;
    [SerializeField] TextMeshProUGUI dialogue;
    [SerializeField] TextMeshProUGUI answer;
    [SerializeField] Manager manager;

 
    public void Display(string newName, Sprite newSprite, string newDialogue)
    {
       _name.text = newName;
        dialogue.text = newDialogue;
        image.sprite = newSprite;
    }

    public void SetToCurrent()
    {
        Display(manager.currentNpc._name, manager.currentCard.sprite, manager.currentCard.dialogue);
    }

    public void DisplayAnswer(string newAnswer)
    {
        answer.text = newAnswer;
    }

    public void EmptyAnswer()
    {
        answer.text = string.Empty;
    }

}

    
