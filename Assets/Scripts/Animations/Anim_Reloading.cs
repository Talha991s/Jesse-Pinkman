using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Reloading : StateMachineBehaviour
{
    private static readonly int IsReloadingHash = Animator.StringToHash("IsReloading");

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool(IsReloadingHash, false);
    }


}
