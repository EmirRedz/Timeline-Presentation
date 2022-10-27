using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField] private Animator playerAnimator;
    [SerializeField]private string[] animationTriggers;

    private void Update()
    {
        for (int i = 0; i < animationTriggers.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                playerAnimator.SetTrigger(animationTriggers[i]);
                break;
            }
        }
    }
}
