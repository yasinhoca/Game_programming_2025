using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("jump", true);
        }
        else if (Input.GetKey(KeyCode.Space) == false) {
            animator.SetBool("jump", false);
        }

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("walk", true);
        }
        else if (Input.GetKey(KeyCode.W) == false)
        {
            animator.SetBool("walk", false);
        }


    }
}
