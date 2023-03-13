using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefuAnimation2 : StateMachineBehaviour
{
    public override void OnStateUpdate(Animator refuanimator, AnimatorStateInfo stateInfo, int layerIndex) 
    {
        Debug.Log("Exit");
        refuanimator.SetBool("wake2",false);
    }
}
