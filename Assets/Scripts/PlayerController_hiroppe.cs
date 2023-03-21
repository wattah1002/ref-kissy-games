using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_hiroppe : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;

    private float move;
    [SerializeField]
    private float moveSence = 1.0f;
    private float jumpSpeed = 500f;
    [SerializeField]
    private bool isGround = true;
    
    public GameObject _camera;
    private float[] leftSide = {-230,250};
    private int fieldNum = 0;

    private bool fieldFlag = true;
    private bool moveFlag = true;


    void Start(){
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update(){
        PlayerMoveHorizontal();
        PlayerMoveJump();
        WaitProcess();
    }

    void PlayerMoveHorizontal(){
        //左右移動
        move = Input.GetAxis("Horizontal");
        if(transform.position.x > leftSide[fieldNum] && transform.position.x < 720){
            if(move != 0 && moveFlag){
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
        else transform.position = new Vector3(leftSide[fieldNum] + 1, transform.position.y, 1);
    }

    void PlayerMoveJump(){
        if(isGround&&(Input.GetKeyDown("up")||Input.GetKeyDown(KeyCode.Space)&&moveFlag)){

            rb.AddForce(transform.up * jumpSpeed, ForceMode2D.Impulse);
            isGround = false;
        }
    }

    void WaitProcess(){
        if(fieldFlag && transform.position.x >= 240){
            fieldFlag = false;
            moveFlag = false;
        }
        if(!moveFlag){
            Debug.Log("動けない");
            if(_camera.GetComponent<CameraController_hiroppe>().WaitCamera()){
                fieldNum++;
                moveFlag = true;
            }
        }
        
    }



    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "Field"){
            isGround = true;
        }
    }
}
