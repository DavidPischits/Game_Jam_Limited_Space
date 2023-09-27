using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTransform : MonoBehaviour
{
    MouseActions mouseActions;
    [SerializeField] Transform transformSlot;
    [SerializeField] Transform transformSlot2;
    [SerializeField] Transform transformSlot3;
    [SerializeField] Transform transformSlot4;
    [SerializeField] Transform transformSlot5;
    [SerializeField] Transform transformSlot6;
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] float speed = 1;
    [SerializeField] float xAdd = 0;
    [SerializeField] float YAdd = 0;

    void Awake()
    {
        mouseActions = GameObject.FindObjectOfType<MouseActions>().GetComponent<MouseActions>();
        if(gameObject.GetComponent<Rigidbody2D>() == null )
        {
            gameObject.AddComponent<Rigidbody2D>();
            rigid = gameObject.GetComponent<Rigidbody2D>();
        rigid.gravityScale = 0;
        }
    }

    void Start()
    {
        TransformToSlot();
    }



    public void TransformWithMouse()
    {
        var a = new Vector2(mouseActions.mousePos.x + xAdd, mouseActions.mousePos.y + YAdd);
        transform.SetAsLastSibling();
        transform.position = Vector2.MoveTowards(a,a , Time.fixedDeltaTime * speed);
        //rigid.MovePosition(new Vector2(mouseActions.mousePos.x + xAdd, mouseActions.mousePos.y + YAdd * Time.fixedDeltaTime * speed));
        
        
    }

    public void TransformToSlot()
    {
        transform.position = transformSlot.position;
    }
}
