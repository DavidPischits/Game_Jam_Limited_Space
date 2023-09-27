using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/new Application")]

public class Applicant : ScriptableObject
{

    [Header("Properties")]
    public List<Property> properties = new List<Property>();
    public WorkObject workObject;   
    public ApplicationObject application;

    [Header("Name")]
    [SerializeField] public string FirstName;
    [SerializeField] public string LastName;

    [Header("Birthday")]
    [SerializeField] public int Day;
    [SerializeField] public int Month;
    [SerializeField] public int Year;
    

    public Applicant(string first, string last, int day, int month, int year)
    {
        FirstName = first;
        LastName = last;
        Day = day;
        Month = month;
        Year = year;
        name = first + " " + last;
    }

}


