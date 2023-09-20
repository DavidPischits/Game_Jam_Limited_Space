using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChefManager : MonoBehaviour
{
    public List<Chef> chefs = new List<Chef>();
    [field: SerializeField] public Chef currentChef { get; private set; }


    public void NewApplication()
    {
        currentChef = chefs[Random.Range(0, chefs.Count)];
    }

    void Start()
    {
        foreach(Chef chef in chefs)
        {
            if(chef.unDesiredSex == chef.desiredSex) { Debug.LogError("A desired property of " + chef.name + " is the same as an undesired one of him"); }
        }
    }
}
