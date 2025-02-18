using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorControl : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "door")
        {
            Animator anim = other.GetComponentInChildren<Animator>();
            anim.SetTrigger("openclose");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "door")
        {
            Animator anim = other.GetComponentInChildren<Animator>();
            anim.SetTrigger("openclose");
        }
    } 

}
