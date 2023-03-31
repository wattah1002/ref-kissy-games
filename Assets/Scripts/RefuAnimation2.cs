using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefuAnimation2 : StateMachineBehaviour
{
    GameObject RefuNoid;
    SleepingController sleepingcontroller;
    public override void OnStateExit(Animator refuanimator, AnimatorStateInfo stateInfo, int layerIndex) 
    {
        refuanimator.SetBool("wake2",false);
        RefuNoid = GameObject.Find("refu_noid");
        sleepingcontroller = RefuNoid.GetComponent<SleepingController>();
        if(sleepingcontroller.CleanHits <= 10)
        {
            sleepingcontroller.IsSleeping = true;
            sleepingcontroller.CleanHits = 0;
            sleepingcontroller.sound_Zz.Play();
        }
        Debug.Log(sleepingcontroller.IsSleeping);
        // Debug.Log("wake2_idle");
    }
}
