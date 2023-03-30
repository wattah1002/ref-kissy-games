using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefuAnimation3 : StateMachineBehaviour
{
    GameObject sleepingmeter;
    SleepMeter sleepmeter;
    Animator refuanimator;

    [SerializeField]GameObject RefuNoid;
    SleepingController sleepingcontroller;

    public override void OnStateUpdate(Animator refuanimator, AnimatorStateInfo stateInfo, int layerIndex) 
    {
        RefuNoid = GameObject.Find("refu_noid");
        sleepingcontroller = RefuNoid.GetComponent<SleepingController>();

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

        if(sleepingcontroller.CleanHits <= 10)
        {
            sleepingcontroller.IsSleeping = true;
            sleepingcontroller.CleanHits = 0;
            sleepingcontroller.sound_Zz.Play();
        }
        Debug.Log(sleepingcontroller.IsSleeping);
    }
}
