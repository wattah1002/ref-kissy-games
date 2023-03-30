using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefuAnimation4 : StateMachineBehaviour
{
    [SerializeField]GameObject sound_over;
    public override void OnStateEnter(Animator refuanimator, AnimatorStateInfo stateInfo, int layerIndex) 
    {
        GameObject Prefab_over = (GameObject)Instantiate(sound_over);
    }
}
