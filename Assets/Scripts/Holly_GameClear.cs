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
                Refunoid.gameObject.SetActive (false);
                Debug.Log("GAMEOVER");
                // sound_Zz.Pause();
                Instantiate(ClearEffect.gameObject, EffectPoint.transform.position, Quaternion.identity);
            }
            else//壁に当たったときに、ゲームオーバー判定でないならクリア
            {
                Refunoid.gameObject.SetActive (false);
                Debug.Log("clear!!!");
                SceneManager.LoadScene("HollyClear");
                // sound_Zz.Pause();
            }
            
        }
        // if(other.gameObject.tag == "Wall")
        // {
        //     Debug.Log("clear!!!!!!!");
        //     Instantiate(ClearEffect.gameObject, EffectPoint.transform.position, Quaternion.identity);
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
