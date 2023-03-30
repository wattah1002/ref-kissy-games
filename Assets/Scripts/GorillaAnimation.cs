using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GorillaAnimation : StateMachineBehaviour
{
    public override void OnStateEnter(Animator GorillaAnim, AnimatorStateInfo stateInfo, int layerIndex) 
    {
            GorillaAnim.SetBool("Shot",false);
    }
}
