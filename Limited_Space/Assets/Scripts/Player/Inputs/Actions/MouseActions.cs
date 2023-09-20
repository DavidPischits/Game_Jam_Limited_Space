using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class MouseActions : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] ObjectManager objManager;
    [SerializeField] RaycastHit2D hit;
    [SerializeField] RaycastHit2D uiHit;
    [SerializeField] LayerMask controlLayer;
    [SerializeField] LayerMask objectLayer;
    [SerializeField] LayerMask buttonLayer;
    RaycastHit2D buttonHit;
    [SerializeField] PaperObjectSM paperObject;
    public Vector2 mousePos;

 

    public void SetPaper()
    {
        hit = Physics2D.Raycast(mainCamera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, 10000, objectLayer);
        buttonHit = Physics2D.Raycast(mainCamera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, 10000, buttonLayer);
        if (hit)
        {
            objManager.SetObjectSM(hit.collider.gameObject.GetComponent<ObjectSM>());



        }

        else if(buttonHit)
        {
            if(buttonHit.collider.gameObject.layer == Layers.YesButtonLayer)
            {
                objManager.SetButton( buttonHit.collider.gameObject.GetComponent<But>());
                objManager.currentButton.ChangeButtonState(ButtonState.pressed);
            }
        }

    }

    public void Move()
    {
        if(objManager.currentObjectSM != null)
        {
            hit = Physics2D.Raycast(mainCamera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, 10000);
            objManager.currentObjectSM.ChangeState(State.Picked);
            mousePos = hit.point;

        }
    }

    public void CheckButton()
    {

    }



    public void CheckUI()
    {
        if (objManager.currentObjectSM != null)
        {
                uiHit = Physics2D.Raycast(mainCamera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, 10000, controlLayer);
            if (uiHit)
            {
                objManager.currentObjectSM.ChangeState(State.DroppedOnDesk);
            }

            else
            {
                objManager.currentObjectSM.ChangeState(State.Dropped);

            }

        }


    }

}


