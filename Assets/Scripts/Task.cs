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
    string GPU;

    //CPU
    string CPU;

    //DDR
    string DDR;

    //SSD and HDD
    string SSD;
    string HDD;

    //PSU
    string PSU;

    //Materinka
    string LGA;

    //Corpus
    string Corpus;

    //Score
    private string score;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if(other.gameObject.name == "GPU_1")
        {

        }
    }

    private void Update()
    {
        if(task1 == true)
        {
            if (GPU == "GPU_1")
            {
                score += 1;
            }

            if (CPU == "CPU_1")
            {
                score += 1;
            }

            if (DDR == "DDR4")
            {
                score += 1;
            }

            if (SSD == "SSD_1" || HDD == "HDD_1")
            {
                score += 1;
            }

            if (PSU == "PSU_1")
            {
                score += 1;
            }

            if (LGA == "LGA_1")
            {
                score += 1;
            }

            if (Corpus == "Corpus_1")
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
