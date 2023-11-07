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
        // Forward
        if (Input.GetKey(KeyCode.W)){
            animator.SetBool("WalkForwards", true);

            // Run
            if (Input.GetKey(KeyCode.LeftShift)){
                animator.SetBool("Run", true);
            }
            else{
                animator.SetBool("Run", false);
            }
        }
        else{
            animator.SetBool("WalkForwards", false);
        }

        // Backward
        if (Input.GetKey(KeyCode.S)){
            animator.SetBool("WalkBackwards", true);

            // Run
            if (Input.GetKey(KeyCode.LeftShift)){
                animator.SetBool("Run", true);
            }
            else{
                animator.SetBool("Run", false);
            }
        }
        else{
            animator.SetBool("WalkBackwards", false);
        }

        // Left
        if (Input.GetKey(KeyCode.A)){
            animator.SetBool("WalkLeft", true);

            // Run
            if (Input.GetKey(KeyCode.LeftShift)){
                animator.SetBool("Run", true);
            }
            else{
                animator.SetBool("Run", false);
            }
        }
        else{
            animator.SetBool("WalkLeft", false);
        }

        // Right
        if (Input.GetKey(KeyCode.D)){
            animator.SetBool("WalkRight", true);

            // Run
            if (Input.GetKey(KeyCode.LeftShift)){
                animator.SetBool("Run", true);
            }
            else{
                animator.SetBool("Run", false);
            }
        }
        else{
            animator.SetBool("WalkRight", false);
        }

    }
}
