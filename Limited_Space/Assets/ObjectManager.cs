using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public ObjectSM currentObjectSM;
    public But currentButton;
    public List<ObjectSM> objects = new List<ObjectSM>();

    public void SetButton(But button)
    {
        currentButton = button;
    }

    public void SetObjectSM(ObjectSM pickableObj)
    {
        currentObjectSM = pickableObj;
    }

    public void SetToNull()
    {
        currentObjectSM = null;
    }



}
