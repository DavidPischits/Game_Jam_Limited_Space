using System.Collections.Generic;
using UnityEngine;

public class ApplicationManager : MonoBehaviour
{
    public List<App> apps = new List<App>();
    [field: SerializeField] public App currentApp { get; private set; }


    public void NewApplication()
    {
        currentApp = apps[Random.Range(0, apps.Count)];
    }

    public void Start()
    {
        
    }
}
