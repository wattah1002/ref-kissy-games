using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;

    private float move;
    [SerializeField]
    private float moveSence = 1.0f;
    private float jumpSpeed = 500f;
    [SerializeField]
    private bool isGround = true;
    


    void Start(){
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        PlayerMoveHorizontal();
        PlayerMoveJump();
    }

    void PlayerMoveHorizontal(){
        //左右移動
        move = Input.GetAxis("Horizontal");
        if(transform.position.x > -230){
            if(move != 0){
                if(move >= 0) move =1;
                else move = -1;

                anim.SetBool("isWalk", true);
                transform.localScale = new Vector3(move * 17, 17, 1);
                transform.position += new Vector3(move * moveSence, 0,0);
            }
            else {
                anim.SetBool("isWalk",false);
            }
        }
        else transform.position = new Vector3(-229, transform.position.y, 1);
    }

    void PlayerMoveJump(){
        if(isGround&&(Input.GetKeyDown("up")||Input.GetKeyDown(KeyCode.Space))){

            rb.AddForce(transform.up * jumpSpeed, ForceMode2D.Impulse);
            isGround = false;
        }
    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "Field"){
            isGround = true;
        }
    }
}
