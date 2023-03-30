using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefuAnimation5 : StateMachineBehaviour
{
    GameObject RefuNoid;
    SleepingController sleepingcontroller;
    public override void OnStateEnter(Animator refuanimator, AnimatorStateInfo stateInfo, int layerIndex) 
    {
        RefuNoid = GameObject.Find("refu_noid");
        sleepingcontroller = RefuNoid.GetComponent<SleepingController>();
        sleepingcontroller.sound_Zz.Pause();
    }
}
