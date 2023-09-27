using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectProp : Property
{
    [field: SerializeField] public GameObject obj { get; private set; }
}
