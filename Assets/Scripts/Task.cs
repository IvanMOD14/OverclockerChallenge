using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Task : MonoBehaviour
{
    //Task
    public static bool task1;
    public static bool task2;
    public static bool task3;

    public GameObject Task_1;
    public GameObject Task_2;
    public GameObject Task_3;
    public static int score;
    public static int AllComponent;

    public void Task1()
    {
        task1 = true;
        Task_1.SetActive(true);
    }

    public void Task2()
    {
        task2 = true;
        Task_2.SetActive(true);
    }

    public void Task3()
    {
        task3 = true;
        Task_3.SetActive(true);
    }

    private void Update()
    {
        if (score >= 8 & AllComponent >= 9)
        {
            Task_1.SetActive(false);
            task1 = false;
            Monik.startTask1 = 2;
            MousController.maney += 1000;
            AllComponent = 0;
            score = 0;
        }
    }
}
