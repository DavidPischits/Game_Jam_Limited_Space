using System.Collections.Generic;
using UnityEngine;

public class WorkDaySystem : MonoBehaviour
{
    [SerializeField] AppManager appManager;
    [SerializeField] ChefManager chefManager;
    [SerializeField] WorkDay currentWorkDay;
    [SerializeField] DesireSystem desireSystem;
    [SerializeField] AppDisplay appDisplay;
    [SerializeField] PlayerStats playerStats;
    [SerializeField] UISM ui;
    [SerializeField] RuleManager ruleManager;
    void Awake()
    {
        appDisplay = GameObject.FindObjectOfType<AppDisplay>().GetComponent<AppDisplay>();
        ui = GameObject.FindObjectOfType<UISM>().GetComponent<UISM>();
    }



    public void StartWorkDay()
    {
        foreach(Applicant app in currentWorkDay.appList.list)
        {
            appManager.currentApps.Add(app);
        }
        ruleManager.positiveRules = currentWorkDay.positiveRules;
        ruleManager.negativeRules = currentWorkDay.negativeRules;

        appManager.NewCurrentApp();
    }

    public void EndWorkDay()
    {
        desireSystem.CompareLists();

        ui.ChangeState(UISM.UIState.End);

    }

}
