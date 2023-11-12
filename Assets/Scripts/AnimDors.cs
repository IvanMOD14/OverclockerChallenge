using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimDors : MonoBehaviour
{
    public Animator animator;
    bool chek;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OpenDors()
    {
        if (chek == true)
        {
            animator.SetBool("Open", true);
            chek = false;
            return;
        }


        if (chek == false)
        {
            animator.SetBool("Open", false);
            chek = true;
            return;
        }
    }
}
