using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc_Pick : MonoBehaviour
{
    NpcManager manager;

    void Awake()
    {
        manager  = GameObject.FindObjectOfType<NpcManager>().GetComponent<NpcManager>();
    }
    public Npc PickNpc()
    {
        return manager.currentNpc = manager.NpcList[Random.Range(0, manager.NpcList.Count)];
    }
}
