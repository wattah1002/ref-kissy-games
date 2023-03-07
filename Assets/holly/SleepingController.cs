using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepingController : MonoBehaviour
{
    private GameObject sleepingmeter;
    SleepMeter sleepmeter;

    private bool IsSleeping;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        IsSleeping = true;
        anim = GetComponent<Animator>();

            sleepingmeter = GameObject.Find("SleepMeter");
            sleepmeter = sleepingmeter.GetComponent<SleepMeter>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "VeryCuteBullet")
        {
            float Nemusa = sleepmeter.SleepingBarometer --;
            Debug.Log(Nemusa);

            if(IsSleeping==true)//寝ているなら
            {
                if(Nemusa <= 0)
                {
                    Debug.Log("Clear!!!!!!");
                }
                else if(Nemusa < 25)
                {
                    anim.SetBool("wake3",true);
                    // IsSleeping = false;
                }
                else if(Nemusa< 35)
                {
                    anim.SetBool("wake1",true);
                    // IsSleeping = false;
                }
                else if(Nemusa < 50)
                {
                    anim.SetBool("wake2",true);
                    // IsSleeping = false;
                }
            }
            else//覚醒状態なら
            {
                if(Nemusa < 25)
                {
                    anim.SetBool("awake",true);
                    Debug.Log("GAMEOVER");
                }
            }
        }
    }
}
