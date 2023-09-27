using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using System;

public class MouseActions : MonoBehaviour
{

    public static event Action<ObjectProp> OnDeskHit;
    public static event Action<ObjectProp> OnAwayFromDesk;
    [SerializeField] Camera mainCamera;
    [SerializeField] ObjectManager objManager;
    [SerializeField] RaycastHit2D hit;
    [SerializeField] RaycastHit2D deskHit;
    [SerializeField] RaycastHit2D controlHit;
    [SerializeField] LayerMask controlLayer;
    [SerializeField] LayerMask objectLayer;
    [SerializeField] LayerMask buttonLayer;
    [SerializeField] LayerMask deskLayer;
    [SerializeField] DeskCheck desk;
    [SerializeField] AudioManager audioManager;
    RaycastHit2D buttonHit;
    [SerializeField] PaperObjectSM paperObject;
    public Vector2 mousePos;
    
     


    public void Update()
    {
        buttonHit = Physics2D.Raycast(mainCamera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, 10000, buttonLayer);
        deskHit = Physics2D.Raycast(mainCamera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, 10000, controlLayer);
        controlHit = Physics2D.Raycast(mainCamera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, 10000, deskLayer);
        hit = Physics2D.Raycast(mainCamera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, 10000, objectLayer);



    }
    public void SetPickable()
    {
        

      
         if (hit)
        {

            objManager.SetObjectSM(hit.collider.gameObject.GetComponent<ObjectSM>());
            audioManager.PlayClip(audioManager.clip);


        }

        else if(buttonHit)
        {
           
                objManager.SetButton( buttonHit.collider.gameObject.GetComponent<But>());
                objManager.currentButton.ChangeButtonState(ButtonState.pressed);
                audioManager.PlayClip(audioManager.clip);
            Debug.Log("button");

            
        }


    }

    public void Move()
    {
        if (objManager.currentObjectSM != null)
        {
            hit = Physics2D.Raycast(mainCamera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, 10000);
            objManager.currentObjectSM.ChangeState(State.Picked);
            mousePos = hit.point;

        }



    }
    public void CheckUI()
    {
        if (objManager.currentObjectSM != null)
        {
        var currentProp = objManager.currentObjectSM.objectProp;
            if (deskHit)
            {
                objManager.currentObjectSM.ChangeState(State.DroppedOnDesk);
            }

            else if(controlHit)
            {
                objManager.currentObjectSM.ChangeState(State.Cold);
                OnDeskHit?.Invoke(currentProp);
            }

            else if(controlHit == false)
            {
                objManager.currentObjectSM.ChangeState(State.DroppedOnDesk);
                OnAwayFromDesk?.Invoke(currentProp);
            }


            else
            {
                objManager.currentObjectSM.ChangeState(State.Dropped);

            }

        }
        objManager.SetToNull();


    }
        void OnEnable()
        {
            OnAwayFromDesk += desk.Add;
            OnDeskHit += desk.Remove;
        }


}


