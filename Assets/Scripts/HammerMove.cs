using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerMove : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            anim.SetBool("onClick", true);
        }
        else{
            anim.SetBool("onClick", false);
        }
    }
}
