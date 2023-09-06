using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackActions : MonoBehaviour
{
    
    public static AttackStates attackStates = AttackStates.OutRange;
    GameObject otherPassanger;
    public enum AttackStates
    {
        OutRange,
        InRange,
    }

    public void Update()
    {
       switch(attackStates)
        {
            case AttackStates.OutRange:
                break;
            case AttackStates.InRange: 
                break;
        }
    }

    public void SetOutRange()
    {
        attackStates = AttackStates.OutRange;
    }

    public void SetInRange()
    {
        attackStates = AttackStates.InRange;
    }

    public void SetPassanger(GameObject other)
    {
        otherPassanger = other; 
    }
    public void AttackPassanger()
    {
        if(attackStates == AttackStates.InRange)
        {
            Destroy(otherPassanger); 
        }
    }
}
