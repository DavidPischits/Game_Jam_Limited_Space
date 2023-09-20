using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTransform : MonoBehaviour
{
    MouseActions mouseActions;
    [SerializeField] Transform transformSlot;

    void Awake()
    {
        mouseActions = GameObject.FindObjectOfType<MouseActions>().GetComponent<MouseActions>();
    }

    void Start()
    {
        TransformToSlot();
    }
    public void TransformWithMouse()
    {
        transform.position = mouseActions.mousePos;
    }

    public void TransformToSlot()
    {
        transform.position = transformSlot.position;
    }
}
