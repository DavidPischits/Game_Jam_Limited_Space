using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcManager : MonoBehaviour
{
    public Npc currentNpc;
    [SerializeField] public List<Npc> NpcList = new List<Npc>();

    void Start()
    {
       //if(NpcList.Count == 0)
       //{
       //     Debug.LogError("NpcList is empty");
       //}
    }



}
