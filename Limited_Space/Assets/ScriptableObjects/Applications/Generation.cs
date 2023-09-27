using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Generation : MonoBehaviour
{
    [SerializeField] static List<string> firstNames = new List<string>();
    [SerializeField] static List<string> lastNames  = new List<string>();
    [SerializeField] List<string> firstSerialized = new List<string>();
    [SerializeField] List<string> lastSerialized = new List<string>();

    void Start()
    {
        firstNames = firstSerialized;
        lastNames = lastSerialized;
    }
    public static int GenerateDay()
    {
        return Random.Range(0, 29); 
    }

    public  static int GenerateMonth()
    {
        return Random.Range(0, 12);

    }

    public static int GenerateYear()
    {
        return Random.Range(1930, 1950);
    }

    public static string GenerateFirstName()
    {
        return firstNames[Random.Range(0, firstNames.Count)];
    }

    public static string GenerateLastName()
    {
        return lastNames[Random.Range(0, lastNames.Count)];
    }

    public static bool GeneratePropablity(int probability)
    {
        if(Random.Range(0, 100) <= probability )
        {
            return true;
        }

        else
            return false;
    }
}
