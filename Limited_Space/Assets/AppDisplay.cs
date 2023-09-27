using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AppDisplay : MonoBehaviour
{
    public TextMeshProUGUI Name;
    [SerializeField] AppManager appManager;


    void Update()
    {
        DisplayCurrent();
    }
    public void DisplayCurrent()
    {
        Name.text = "Name: " + appManager.currentApp.FirstName;
    }
    

}

    
