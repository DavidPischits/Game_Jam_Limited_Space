using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsCalculation : MonoBehaviour
{
    [SerializeField] DesireSystem desireSystem;
    [SerializeField] AppManager appManager;


    public void CalculateStats()
    {
        foreach(Applicant acceptedApp in appManager.acceptedApps)
        {
            
        }

    
    }
}
