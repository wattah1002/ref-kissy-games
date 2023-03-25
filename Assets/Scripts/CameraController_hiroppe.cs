using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController_hiroppe : MonoBehaviour
{
    private bool moveFlag = false;
    [SerializeField]
    private int moveSpeed = 3;
    void Start(){
        transform.position = new Vector3(0,0,-10);
    }

    void Update(){
        if(moveFlag) {
            transform.position += new Vector3(moveSpeed,0,0);
        }
    }

    public bool WaitCamera(){
        if(transform.position.x>=480){
            moveFlag = false;
            transform.position = new Vector3(480,0,-10);
            return true;
        }
        else {
            moveFlag = true;
            return false;
        }
    }
    public void ResetPos(){
        transform.position = new Vector3(0,0,-10);
    }
}
