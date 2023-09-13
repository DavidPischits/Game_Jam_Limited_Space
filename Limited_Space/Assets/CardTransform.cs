using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardTransform : MonoBehaviour
{
    [SerializeField] GameObject serializedCard;
    GameObject card;
    [SerializeField] float rotationAroundSelfSpeed;
    [SerializeField] float rotationToMiddleSpeed;
    [SerializeField] Quaternion middleQuaternion;

     public void Start()
    {
        card = serializedCard;
    }

    public void MoveCardToLeft()
    {
        card.transform.DOMove(new Vector3(-10, 0, 0), 1f).SetLoops(0).SetEase(Ease.Linear);
    }
    public void MoveCardToRight()
    {
        card.transform.DOMove(new Vector3(10, 0, 0), 1f).SetLoops(0).SetEase(Ease.Linear);
    }

    public void RotateCardLeft()
    {
        card.transform.DORotate(new Vector3(0, 0, 10), .5f).SetLoops(0).SetEase(Ease.Linear);
    }

    public void RotateCardAroundSelf()
    {
        card.transform.DORotate(new Vector3(0 , 360, 0), Time.deltaTime * rotationAroundSelfSpeed, RotateMode.LocalAxisAdd).SetLoops(0).SetEase(Ease.Linear);
    }

    public void RotateCardToMiddle()
    {

        card.transform.DORotate(Vector3.zero, rotationToMiddleSpeed * Time.deltaTime).SetLoops(0).SetEase(Ease.Linear);
    }

    public void RotateCardRight()
    {
        card.transform.DORotate(new Vector3(0, 0, -10), .5f).SetLoops(0).SetEase(Ease.Linear);
    }


}
