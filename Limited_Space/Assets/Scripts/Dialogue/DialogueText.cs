using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class DialogueText : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public float textSpeed;
    public bool running;

    private int index;


    void Awake()
    {
    }

    void Start()
    {
        Running(false);
        EmptyBox();
    }
    public void StartDialogue(string text)
    {
        Running(true);
        index = 0;
        StartCoroutine(TypeLine(text));
    }

    IEnumerator TypeLine(string text)
    {
        foreach(char c in text.ToCharArray())
        {
            textMeshPro.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    yield return null;
        Running(false);

    }

    public void EmptyBox()
    {
        textMeshPro.text = string.Empty;
    }

    public bool Running(bool value)
    {
          running = value;
        return running;
    }

}
