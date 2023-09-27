using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChefManager : MonoBehaviour
{
    public List<Worker> chefs = new List<Worker>();
    [field: SerializeField] public Worker currentChef { get; private set; }


    public void SetChef(Worker chef)
    {
        currentChef = chef;
    }

    void Start()
    {
      
    }
}
