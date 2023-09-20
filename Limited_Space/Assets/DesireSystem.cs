using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class DesireSystem : MonoBehaviour
{
    [SerializeField] ChefManager chefManager;
    [SerializeField] ApplicationManager appManager;
    [SerializeField] Stats stats;
    Chef chef;
    App app;

 
    public void CheckDesire()
    {
        chef = chefManager.currentChef;
        app = appManager.currentApp;
        if (chef.desiredSex == Sex.none) { }

        else
        {
            if (app.sex == chef.desiredSex) { Debug.Log("Same sex"); }

        }





    }

    public void CheckNegativeDesires()
    {

        if (chef.unDesiredSex == Sex.none) { }

        else
        {
            if (app.sex == chef.unDesiredSex)
            {
                stats.LowerFood();
            }


        }
    }
}
