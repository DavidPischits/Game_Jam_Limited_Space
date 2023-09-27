using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectDisplay : MonoBehaviour
{
    public TextMeshProUGUI Name;
    [SerializeField] AppManager appManager;

    void Start()
    {
        DisplayCurrent();
    }
    public void DisplayCurrent()
    {
        Name.text = "Name: " + appManager.currentApp.workObject.name;
    }
}
