using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimDors : MonoBehaviour
{
    public Animator animator;
    public static bool chekDoorHous;
    public static bool chekDoorShop1;
    public static bool chekDoorShop2;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OpenDorsHous()
    {
        if (chekDoorHous == true)
        {
            animator.SetBool("Open", true);
            return;
        }


        if (chekDoorHous == false)
        {
            animator.SetBool("Open", false);
            return;
        }
    }

    public void OpenDorsShop1()
    {
        if (chekDoorShop1 == true)
        {
            animator.SetBool("Open1", true);
            return;
        }


        if (chekDoorShop1 == false)
        {
            animator.SetBool("Open1", false);
            return;
        }
    }

    public void OpenDorsShop2()
    {
        if (chekDoorShop2 == true)
        {
            animator.SetBool("Open2", true);
            return;
        }


        if (chekDoorShop2 == false)
        {
            animator.SetBool("Open2", false);
            return;
        }
    }
}
