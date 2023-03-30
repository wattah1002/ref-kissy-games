using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject _canvas;
    private Goal goal;
    // Start is called before the first frame update
    void Start()
    {
      goal = _canvas.GetComponent<Goal>();  
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0,0,5);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0,0,-5);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(5,0,0);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-5,0,0);
        }
        if(transform.position.y<-10)
        {
           transform .position=new Vector3(0,5,0);
        }
    }
    void OnCollisionEnter(Collision col){
    if(col.gameObject.tag == "vanilla"){
        goal.Vanilla();
    }
    if(col.gameObject.tag == "cocoa"){
        goal.Cocoa();
    }
}
}
