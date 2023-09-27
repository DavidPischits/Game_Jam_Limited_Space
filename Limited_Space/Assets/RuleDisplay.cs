using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static DeskCheck;
public class RuleDisplay : MonoBehaviour
{
    
    [SerializeField] TextMeshProUGUI firstRule;
    [SerializeField] TextMeshProUGUI secondRule;
    [SerializeField] TextMeshProUGUI thirdRule;
    [SerializeField] TextMeshProUGUI fourthRule;
    string emptyString = "E";
    [SerializeField] RuleManager ruleManager;


    void Start()
    {

        Debug.Log(gameObject.name);
        foreach(Property rule in ruleManager.positiveRules)
        {
            if(ruleManager.positiveRules.Contains(rule))
            {
                Debug.LogError("A property is in the positive and negative Rule List!");
            }

        }

        SetRules();
    }

   
    void SetRules()
    {
        foreach(Property property in ruleManager.positiveRules)
        {
        if(firstRule.text == emptyString)
            firstRule.text = property.RuleMessage;

        else if(secondRule.text == emptyString)
                secondRule.text = property.RuleMessage;
        else if (thirdRule.text == emptyString)
                thirdRule.text = property.RuleMessage;
        else if (fourthRule.text == emptyString)
                fourthRule.text = property.RuleMessage;
        }

        foreach (Property property in ruleManager.negativeRules)
        {
            if (firstRule.text == emptyString)
                firstRule.text = property.NegativeRuleMessage;

            else if (secondRule.text == emptyString)
                secondRule.text = property.NegativeRuleMessage;
            else if (thirdRule.text == emptyString)
                thirdRule.text = property.NegativeRuleMessage;
            else if (fourthRule.text == emptyString)
                fourthRule.text = property.NegativeRuleMessage;
        }
    }


}
