using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Holly_ClickToGameStart : MonoBehaviour
{
    public Camera camera_object;
    private RaycastHit hit;
    void Update () {
        if (Input.GetMouseButtonDown(0)) //マウスがクリックされたら
        {
            Ray ray = camera_object.ScreenPointToRay(Input.mousePosition); //マウスの座標にRayを投げる

                if(Physics.Raycast(ray,out hit))  //何かにRayが当たったらhitに入れる
                {
                    if(hit.collider.gameObject.name == "glasses")
                    {
                        SceneManager.LoadScene("HollyScene");
                    }
                }
        }
    }
}
