using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private Animator animator;

    void Start(){
        animator = GetComponent<Animator>();
    }

    void Update(){
        // Walk or run
        if (Input.GetKey(KeyCode.W)){
            animator.SetBool("Walk", true);

            if (Input.GetKey(KeyCode.LeftShift)){
                animator.SetBool("Walk", false);
                animator.SetBool("Run", true);
            }
            else{
                animator.SetBool("Walk", true);
                animator.SetBool("Run", false);
            }
        }
        else{
            animator.SetBool("Walk", false);
        }
    }
}
