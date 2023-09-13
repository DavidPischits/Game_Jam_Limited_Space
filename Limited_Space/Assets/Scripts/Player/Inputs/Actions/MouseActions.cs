using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using DG.Tweening;

 

public class MouseActions : MonoBehaviour
{
    [SerializeField] Collider2D leftCollider;
    [SerializeField] Collider2D rightCollider;
    [SerializeField] Collider2D middleTransform;
    [SerializeField] Camera mainCamera;
    [SerializeField] LayerMask rightLayer;
    [SerializeField] LayerMask leftLayer;
    [SerializeField]CardSM cardSm;


    public void Update()
    {

        RaycastHit2D hit = Physics2D.Raycast(mainCamera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero , 10000);

        if (hit.collider ==  leftCollider)
        {
            cardSm.ChangeState(CardSM.CardState.Left);
        }

        else if(hit.collider == rightCollider)
        {
            cardSm.ChangeState(CardSM.CardState.Right);
        }

        else if(hit.collider == middleTransform)
        {
            Debug.Log("hit");
            cardSm.ChangeState(CardSM.CardState.Middle);   
        }
    }


}
