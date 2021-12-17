using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    public Animator animator; 
    

    public void PlayAnimationClip()
    {
        animator.Play("burpee");
        Debug.Log("hello");
    }
    
}
