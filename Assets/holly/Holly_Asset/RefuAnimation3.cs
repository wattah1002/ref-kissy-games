using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefuAnimation3 : StateMachineBehaviour
{
    public override void OnStateUpdate(Animator refuanimator, AnimatorStateInfo stateInfo, int layerIndex) 
    {
        Debug.Log("Exit");
        refuanimator.SetBool("wake3",false);
    }
}
