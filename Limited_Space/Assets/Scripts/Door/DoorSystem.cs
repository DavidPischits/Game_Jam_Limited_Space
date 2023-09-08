using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor.Rendering;

public class DoorSystem : MonoBehaviour
{
    DoorData doorData;

    void Awake()
    {
        doorData = GameObject.FindObjectOfType<DoorData>().GetComponent<DoorData>();
    }

    void Update()
    {
        LooseDoorHealth(-50, 10);
    }

    void GainDoorHealth(float amount, float speed)
    {
        if(doorData.currentHealth < amount + doorData.startHealth)
        {
            doorData.currentHealth += Time.deltaTime * doorData.gainSpeed * speed; 
        }

        
    }

    void LooseDoorHealth(float amount, float speed)
    {
        if(doorData.currentHealth > amount + doorData.startHealth)
        {
            doorData.currentHealth -= Time.deltaTime * doorData.gainSpeed * speed;
        }
    }

    public void CheckDoorHealth()
    {
        if (doorData.currentHealth <= 0)
        {
            Debug.Log("Dead");
        }
    }

    void OnEnable()
    {
    }


}
