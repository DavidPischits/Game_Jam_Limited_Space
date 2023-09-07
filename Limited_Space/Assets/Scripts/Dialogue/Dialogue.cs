using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    DialogueText dialogueText;
    DialogueImage dialogueImage;

    void Awake()
    {
        dialogueImage = GameObject.FindObjectOfType<DialogueImage>().GetComponent<DialogueImage>();
        dialogueText = GameObject.FindObjectOfType<DialogueText>().GetComponent<DialogueText>();
    }

    public void StartDialogue(string text, Sprite sprite)
    {

    }
}
