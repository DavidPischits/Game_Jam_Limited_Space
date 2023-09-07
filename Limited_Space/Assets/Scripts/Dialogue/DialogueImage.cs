using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueImage : MonoBehaviour
{
    [SerializeField] Image dialogueImage;
    [SerializeField] Sprite testImage;


    public void ChangeDialogueImage(Sprite sprite)
    {
        dialogueImage.sprite = sprite;
    }
}
