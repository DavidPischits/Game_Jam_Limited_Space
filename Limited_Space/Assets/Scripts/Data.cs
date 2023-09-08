using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    float startChattiness;
    [field: SerializeField]
    public float Chattiness { get; set; }
    [field: SerializeField]
    public float Aggression { get; set; }
    [field: SerializeField]
    public float DoorLock { get; set; }

    void Update()
    {
        if(Chattiness >= 100)
        {
            Debug.Log("Won with Chatiness!");
        }

        else if (Aggression >= 100)
        {
            Debug.Log("Won with Aggression!");
        }

        else if(DoorLock >= 100)
        {
            Debug.Log("Won with Doorlock!");
        }
    }

    public void ChangeStats(float amount)
    {
        

    }
}
