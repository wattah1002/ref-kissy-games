using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TilemapManager_hiroppe : MonoBehaviour
{
    public GameObject[] walls;
    public GameObject[] traps;
    public GameObject FrontScreen;
    public GameObject text;
    private MessageManager_hiroppe mm ;

    private float r;

    void Start(){
        StartCoroutine("StartProcess");
        mm = text.GetComponent<MessageManager_hiroppe>();
        r = Random.Range(0,2);

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
    IEnumerator StartProcess(){
        FrontScreen.SetActive(true);
        yield return new WaitForSeconds(1);
        FrontScreen.SetActive(false);
    }
    IEnumerator ClearProcess(){
        yield return new WaitForSeconds(.5f);
        FrontScreen.SetActive(true);
        FrontScreen.transform.position = new Vector3(480,0,0);
        mm.SetText("クリア！");
        yield return new WaitForSeconds(1);
        mm.SetText("おめでとう！");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }
    IEnumerator GameOverProcess(){
        yield return new WaitForSeconds(.5f);
        FrontScreen.SetActive(true);
        FrontScreen.transform.position = new Vector3(480,0,0);
        mm.SetText("ゲームオーバー！");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("HiroppeScene");
    }
    
}