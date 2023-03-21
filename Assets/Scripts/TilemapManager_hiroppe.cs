using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilemapManager_hiroppe : MonoBehaviour
{
    public GameObject[] walls;
    public GameObject[] traps;

    private float r; 
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
}