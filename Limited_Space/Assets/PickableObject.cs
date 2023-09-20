using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObject : Object
{
    [SerializeField]public ObjectTransform objectTransform;
    [SerializeField] public ObjectSM objectSM;

    void Awake()
    {
        objectTransform =  gameObject.GetComponent<ObjectTransform>();
        objectSM = gameObject.GetComponent<ObjectSM>();
    }




}
