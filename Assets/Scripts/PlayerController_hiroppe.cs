using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_hiroppe : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb ;

    private float move;
    [SerializeField]
    private float moveSence = 1f;
    private float jumpSpeed = 500f;

    private bool isGround = true;
    private bool isSide = false;
    
    public GameObject _camera;
    private float[] leftSide = {-230,250};
    private int fieldNum = 0;

    private bool fieldFlag = true;
    private bool moveFlag = false;

    public GameObject _Grid;

    private bool isStarted = false;

    SoundEffectManager se;

    void Start(){
        anim = GetComponent<Animator>();
        se = GetComponent<SoundEffectManager>();
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(-165, -95, 0);
        StartCoroutine("StartProcess");
        
    }

    void Update(){
        PlayerMoveHorizontal();
        PlayerMoveJump();
        WaitProcess();
    }

    void PlayerMoveHorizontal(){
        //左右移動
        move = Input.GetAxis("Horizontal");
        if(transform.position.x > leftSide[fieldNum] && transform.position.x <= 720){
            if(move != 0 && moveFlag && !isSide){
                //if(move >= 0) move =1;
                //else move = -1;

                anim.SetBool("isWalk", true);
                transform.localScale = new Vector3(Mathf.Sign(move) * 17, 17, 0);
                transform.position += new Vector3(move * moveSence, 0,0);
            }else {
                anim.SetBool("isWalk",false);
            }
        }else if(transform.position.x > 720){
            transform.position = new Vector3(720,transform.position.y,0);
        }else transform.position = new Vector3(leftSide[fieldNum] + 1, transform.position.y, 1);
    }

    void PlayerMoveJump(){
        if(isGround&&(Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow)||Input.GetKeyDown(KeyCode.Space)&&moveFlag)){

            rb.AddForce(transform.up * jumpSpeed, ForceMode2D.Impulse);
            isGround = false;
        }
    }

    void WaitProcess(){
        if(fieldFlag && transform.position.x >= 240){
            fieldFlag = false;
            moveFlag = false;
        }
        if(!moveFlag&&isStarted){
            //Debug.Log("動けない");
            if(fieldNum<1){
                if(_camera.GetComponent<CameraController_hiroppe>().WaitCamera()){
                    fieldNum++;
                    moveFlag = true;
                }
            }
        }
        
    }

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "Field"){
            isGround = true;
        }
        if(col.gameObject.tag == "FieldSide"){
            isSide = true;
        }
        if(col.gameObject.tag == "Trap"){
            moveFlag = false;
            _Grid.GetComponent<TilemapManager_hiroppe>().StartCoroutine("GameOverProcess");
        }
        if(col.gameObject.tag == "Goal"){
            moveFlag = false;
            _Grid.GetComponent<TilemapManager_hiroppe>().StartCoroutine("ClearProcess");
        }
        if(col.gameObject.tag == "Ceiling"){
            se.PlaySE(0);
        }
    }
    void OnCollisionExit2D(Collision2D col){
        if(col.gameObject.tag == "FieldSide"){
            isSide = false;
        }
    }
    IEnumerator StartProcess(){
        yield return new WaitForSeconds(1);
        isStarted = true;
        moveFlag = true;
    }
}
