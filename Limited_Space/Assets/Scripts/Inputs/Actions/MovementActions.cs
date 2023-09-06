using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public  class MovementActions : MonoBehaviour 
{
    public static Vector2 mousePos;
    [SerializeField] Rigidbody2D rigid;
    public float speed = 2f;


    public void Move(Vector2 direction)
    {
        
        rigid.AddForce(direction *  speed *  100 * Time.deltaTime); 
    }
}
