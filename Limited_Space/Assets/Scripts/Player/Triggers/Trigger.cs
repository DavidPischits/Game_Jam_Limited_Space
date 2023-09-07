using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    Npc_Pick npc_Pick;
    DialogueText dialogueText;
    DialogueImage dialogueImage;
    NpcManager manager;


    void Awake()
    {
        dialogueText = GameObject.FindObjectOfType<DialogueText>().GetComponent<DialogueText>();
        npc_Pick = GameObject.FindObjectOfType<Npc_Pick>().GetComponent<Npc_Pick>();
        dialogueImage = GameObject.FindObjectOfType<DialogueImage>().GetComponent<DialogueImage>();
        manager = GameObject.FindObjectOfType<NpcManager>().GetComponent<NpcManager>();

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Area"))
        {
            if (dialogueText.running == false)
            {
                npc_Pick.PickNpc();
                dialogueImage.ChangeDialogueImage(manager.currentNpc.npcSprite);
                dialogueText.StartDialogue(manager.currentNpc.text);

            }
        }
            
    }
}
