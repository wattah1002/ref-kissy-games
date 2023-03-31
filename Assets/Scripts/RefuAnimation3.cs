using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefuAnimation3 : StateMachineBehaviour
{
    GameObject sleepingmeter;
    SleepMeter sleepmeter;
    Animator refuanimator;

    GameObject RefuNoid;
    SleepingController sleepingcontroller;

    public override void OnStateExit(Animator refuanimator, AnimatorStateInfo stateInfo, int layerIndex) 
    {
        sleepingmeter = GameObject.Find("SleepMeter");
        sleepmeter = sleepingmeter.GetComponent<SleepMeter>();
        float Nemusa = sleepmeter.SleepingBarometer;
        // Debug.Log("Wake3_idle");
        if(Nemusa <= 0)
        {
            refuanimator.SetBool("awake",true);
            sleepingcontroller.sound_Zz.Pause();
        }
        else
        {
            refuanimator.SetBool("wake3",false);
        }

        RefuNoid = GameObject.Find("refu_noid");
        sleepingcontroller = RefuNoid.GetComponent<SleepingController>();
        if(sleepingcontroller.CleanHits <= 10)
        {
            sleepingcontroller.IsSleeping = true;
            sleepingcontroller.CleanHits = 0;
            sleepingcontroller.sound_Zz.Play();
        }
        Debug.Log(sleepingcontroller.IsSleeping);
    }
}
