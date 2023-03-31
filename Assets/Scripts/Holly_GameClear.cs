using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Holly_GameClear : MonoBehaviour
{
    public GameObject Refunoid;
    public GameObject ClearEffect;
    public GameObject EffectPoint;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other) 
    {

        if(other.gameObject.tag == "Wall")
        {
            if(anim.GetBool("gameover"))//壁に当たったときに、もしゲームオーバー判定なら
            {
                this.gameObject.SetActive (false);
                Debug.Log("GAMEOVER");
                SceneManager.LoadScene("HollyGameOver");
            }
            else//壁に当たったときに、ゲームオーバー判定でないならクリア
            {
                this.gameObject.SetActive (false);
                Debug.Log("clear!!!");
                SceneManager.LoadScene("HollyClear");
            }
            
        }
        // if(other.gameObject.tag == "Wall")
        // {
        //     Debug.Log("clear!!!!!!!");
            
        //     StartCoroutine("HollyClear");
        // }
    }
    // IEnumerator HollyClear()
    // {
    //     yield return new WaitForSeconds(3);
    //     SceneManager.LoadScene("HollyClear");
    //     Refunoid.gameObject.SetActive (false);
    // }
}
