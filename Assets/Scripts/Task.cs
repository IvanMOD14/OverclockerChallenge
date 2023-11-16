using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Task : MonoBehaviour
{
    //Task
    private bool task1;
    private bool task2;
    private bool task3;

    public GameObject Task_1;

    //GPU
    public int GPU;

    //CPU
    public int CPU;

    //DDR
    public int DDR;

    //SSD and HDD
    public int SSD;
    public int HDD;

    //PSU
    public int PSU;

    //Materinka
    public int LGA;

    //Corpus
    public int Corpus;

    //Score
    public int score;

    private void Update()
    {
        if(task1 == true)
        {
            if (GPU == 1)
            {
                score += 1;
            }

            if (CPU == 1)
            {
                score += 1;
            }

            if (DDR == 1)
            {
                score += 1;
            }

            if (SSD == 1 || HDD == 1)
            {
                score += 1;
            }

            if (PSU == 1)
            {
                score += 1;
            }

            if (LGA == 1)
            {
                score += 1;
            }

            if (Corpus == 1)
            {
                score += 1;
            }
        }
    }

    public void Task1()
    {
        task1 = true;
        Task_1.SetActive(true);
    }
}
