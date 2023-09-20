using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AppDisplay : MonoBehaviour
{

    [SerializeField]ApplicationManager appManager;
    [field: Header("General")]
    [field: SerializeField] public TextMeshProUGUI Name { get; private set; }
    [field: SerializeField] public Image CharSprite { get; private set; }

    [field: Header("Birthday")]
    [field: SerializeField] public TextMeshProUGUI BirthDay { get; private set; }


    [field: Header("Important")]
    [field: SerializeField] public TextMeshProUGUI History { get; private set; }
    [field: SerializeField] public TextMeshProUGUI Education { get; private set; }
    [field: SerializeField] public TextMeshProUGUI Knowledge { get; private set; }
    [field: SerializeField] public TextMeshProUGUI Interests { get; private set; }

    [field: SerializeField] public Color textColor { get; private set; }


    void Start()
    {
        DisplayCurrentApp();
    }

    public void SetTextColor(Color newColor)
    {
        Name.color = newColor;
        BirthDay.color = newColor;
        History.color =   newColor; 
        Education.color = newColor; 
        Knowledge.color = newColor;
        Interests.color = newColor;

    }
    public void DisplayCurrentApp()
    {
        Name.text = "Name: " + appManager.currentApp._Name;
        CharSprite.sprite =  appManager.currentApp.CharSprite;
        BirthDay.text = "BirthDay: " + appManager.currentApp.MonthOfBirth.ToString() + "." +  appManager.currentApp.DayOfBirth.ToString() + "." + appManager.currentApp.YearOfBirth.ToString(); 

        History.text = "History: " + appManager.currentApp.History; 
        Education.text = "Education: " + appManager.currentApp.Education;
        Knowledge.text = "Knowledge: " + appManager.currentApp.Knowledge;   
        Interests.text = "Interests: " + appManager.currentApp.Interests;
    }

}

    
