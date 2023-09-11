using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayActions : MonoBehaviour
{
    [SerializeField]CardDisplay display;
    [SerializeField] Manager manager;


    public void SetToCurrent()
    {
        display.Display(manager.currentNpc._name, manager.currentCard.sprite, manager.currentCard.dialogue);
    }

}
