using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CinemachineControl : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera;
    [field: SerializeField] public CmState state { get; private set; } = CmState.normal;
    [SerializeField] MouseActions mouseActions;
    [SerializeField] Vector3 standartPos;
    [SerializeField] float Rotation;
    [field: SerializeField] public Transform CameraTransform { get; private set; }

    public enum CmState
    {
        normal,
        zoom
    }

    void Update()
    {
        gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);

    }

    public void ChangeState(CmState newState)
    { 
        if (state == newState) { return; } 
        state = newState;

        switch(state)
        {
            case CmState.normal: virtualCamera.m_Lens.OrthographicSize = 20;
                virtualCamera.LookAt = null;
                gameObject.transform.position = standartPos;
                gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
                break;
            case CmState.zoom:  virtualCamera.m_Lens.OrthographicSize = 7;

                CameraTransform.position = new Vector3(mouseActions.mousePos.x, mouseActions.mousePos.y, 0);
                virtualCamera.LookAt = CameraTransform;
                gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);

                break;
        }
    }

}
