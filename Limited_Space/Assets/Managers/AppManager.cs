using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static Generation;

public class AppManager : MonoBehaviour
{
    [field: SerializeField] public List<Applicant> apps { get ; private set; } = new List<Applicant>();
    [field: SerializeField] public List<Applicant> currentApps { get; private set; } = new List<Applicant>();
    [field: SerializeField] public List<Applicant> deniedApps { get; private set; } = new List<Applicant>();
    [field: SerializeField] public List<Applicant> acceptedApps { get; private set; } = new List<Applicant>();
    [field: SerializeField] public Applicant currentApp { get; private set; }
    [SerializeField] WorkDaySystem workDaySystem;
    [SerializeField] Applicant applicant;
    [SerializeField] int numberToAdd;



    void Start()
    {
        for(int i = 0; i <= numberToAdd; i++)
        {
            var applicant = new Applicant(GenerateFirstName(), GenerateLastName(), GenerateDay(), GenerateMonth(), GenerateYear());
            if(GeneratePropablity(90))
            {
                applicant.workObject = new WorkObject(applicant.FirstName, applicant.LastName, WorkObjectType.conform); 
            }

            else
            {
                Debug.Log("Wrong Name");
                applicant.workObject = new WorkObject(applicant.FirstName, GenerateLastName(), WorkObjectType.wrong); 
            }
            currentApps.Add(applicant);
           

        }
    }

    public void RemoveFromCurrent()
    {
        
       currentApps.Remove(currentApp);
    }
    public void MoveToDenied()
    {
       deniedApps.Add(currentApp); 
    }

    public void MoveToAccepted()
    {
        acceptedApps.Add(currentApp);
    }

     public void NewCurrentApp()
     {
        currentApps.Remove(currentApp);
        currentApp = currentApps[0]; 
     }


}
