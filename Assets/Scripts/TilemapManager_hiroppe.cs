using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilemapManager_hiroppe : MonoBehaviour
{
    public GameObject[] walls;
    public GameObject[] traps;

    private float r;
    private bool moveFlag = false; 

    public GameObject _camera;
    public GameObject _player;
    void Start(){
        r = Random.Range(0,2);
        //Debug.Log(r);

        for(int i=0;i<3;i++){
            if(i==r){
                walls[i].SetActive(true);
                traps[i].SetActive(true);
            }
            else{
                walls[i].SetActive(false);
                traps[i].SetActive(false);
            }
        }
    }

    public bool ClearPerform(){
        StartCoroutine("WaitProcess");
        if(moveFlag){
            return true;
        }else{
            return false;
        }
    }

    public bool GameOverPerform(){
        StartCoroutine("WaitProcess");
        if(moveFlag){
            return true;
        }else{
            return false;
        }
    }

    

    IEnumerator WaitProcess(){
        yield return new WaitForSeconds(3);
        _camera.GetComponent<CameraController_hiroppe>().ResetPos();
        _player.GetComponent<PlayerController_hiroppe>().ResetPos();
        moveFlag = true;
        yield return null;
    }
}