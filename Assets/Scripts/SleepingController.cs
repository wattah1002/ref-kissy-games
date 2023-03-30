using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using UnityEngine.SceneManagement;

public class SleepingController : MonoBehaviour
{
    GameObject sleepingmeter;
    SleepMeter sleepmeter;

    public bool IsSleeping;
    public Animator anim;

    public int CleanHits = 0;

    [SerializeField] GameObject ZzEffect;
    RectTransform ZzPosition;

    [SerializeField] GameObject ExclEffect;
    RectTransform ExclPosition;

    public AudioSource sound_Zz;

    // public GameObject ClearEffect;
    // public GameObject EffectPoint;
    
    void Start()
    {
        IsSleeping = true;
        anim = GetComponent<Animator>();
        // 眠さをSleepMeter.csから参照
        sleepingmeter = GameObject.Find("SleepMeter");
        sleepmeter = sleepingmeter.GetComponent<SleepMeter>();
    }

    void Update()
    {
        if(CleanHits >= 11)
                {
                    sound_Zz.Stop();
                }
    }
    void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "VeryCuteBullet")
        {
            float Nemusa = sleepmeter.SleepingBarometer --;
            // Debug.Log(Nemusa);

            if(IsSleeping==true)//寝ているならアニメーションを読み込む
            {
                if(Nemusa < 25)
                {
                    anim.SetBool("wake3",true);
                    IsSleeping = false;
                }
                else if(Nemusa< 35)
                {
                    anim.SetBool("wake1",true);
                    IsSleeping = false;
                }
                else if(Nemusa < 50)
                {
                    anim.SetBool("wake2",true);
                    IsSleeping = false;
                }
            }
            else//覚醒状態
            {

                // 覚醒中に当たった個数をカウントして10以上になったらゲームオーバー
                CleanHits ++;
                Debug.Log(CleanHits);

                if(CleanHits <= 4)//当たった個数が4個以下ならZzのエフェクトを表示する
                {
                    GameObject ZzPrefab = (GameObject)Instantiate(ZzEffect);
                    Debug.Log(ZzPrefab);
                    ZzPrefab.transform.SetParent(sleepingmeter.transform, false);
                    ZzPosition = ZzPrefab.GetComponent < RectTransform > ();
                    ZzPosition.localPosition = new Vector3(268, 0, 0);
                }
                else if(CleanHits <= 10)//当たった個数が10個以下ならZzのエフェクトを表示する
                {
                    GameObject ExclPrefab = (GameObject)Instantiate(ExclEffect);
                    ExclPrefab.transform.SetParent(sleepingmeter.transform, false);
                    ExclPosition = ExclPrefab.GetComponent < RectTransform > ();
                    ExclPosition.localPosition = new Vector3(268, 0, 0);
                    sound_Zz.Pause();
                }
                else if(CleanHits >= 11)
                {
                    anim.SetBool("gameover",true);
                    Debug.Log("OVER!!!!!!!!!!!!!");
                    sound_Zz.Pause();
                }
            }
        }
    }
}
