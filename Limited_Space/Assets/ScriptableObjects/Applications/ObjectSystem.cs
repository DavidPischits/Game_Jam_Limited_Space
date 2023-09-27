using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSystem : MonoBehaviour
{
    [SerializeField] AppManager appManager;
    [SerializeField] GameObject workObject;
    [SerializeField] public static WorkObject workNormal;
    [SerializeField] public GameObject paperObject;
    [SerializeField] public WorkObject workSerialized;
    [SerializeField] public Application appSerialized;
    [SerializeField] public static Application applicationNormal;
    [SerializeField] ApplicationObject application;
    [SerializeField] GameObject applicationObject;

    void Start()
    {
        workNormal = workSerialized;
        applicationNormal = appSerialized;
    }
    public void EnableObjects()
    {
        if(appManager.currentApp.workObject != null)
        {
            workObject.SetActive(true);

        }

        else if(appManager.currentApp.workObject == null)
        {
            workObject.SetActive (false);
        }

       applicationObject.SetActive(true);
    }

    public void EnablePaperObject()
    {
        paperObject.SetActive(true);
        var sm = paperObject.GetComponent<PaperObjectSM>();
        sm.ChangeState(State.Cold);
        
    }

    public void DisableObjects()
    {
        workObject.SetActive(false);
        applicationObject.SetActive(false);
    }
}
