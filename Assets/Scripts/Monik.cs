using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monik : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;

    public GameObject canvas;

    public GameObject task1;
    public GameObject task2;
    public GameObject task3;

    public GameObject taskMenu;

    public static int startTask1 = 1;
    public static int startTask2;
    public static int startTask3;

    public GameObject pointer;

    public void Exit()
    {
        camera1.enabled = true;
        camera2.enabled = false;
        pointer.SetActive(true);
        canvas.SetActive(true);
    }

    public void ExitTask()
    {
        taskMenu.SetActive(true);
        task1.SetActive(false);
        task2.SetActive(false);
        task3.SetActive(false);
    }

    public void Task1()
    {
        if (startTask1 == 1)
        {
            task1.SetActive(true);
            taskMenu.SetActive(false);
        }
    }

    public void Task2()
    {
        if (startTask1 == 2)
        {
            task2.SetActive(true);
            taskMenu.SetActive(false);
        }
    }

    public void Task3()
    {
        if (startTask1 == 3)
        {
            task3.SetActive(true);
            taskMenu.SetActive(false);
        }
    }

    public void StartTask1() 
    {
        startTask1 = 1;
        PlayerPrefs.SetInt("Task1", startTask1);
        PlayerPrefs.Save();
    }

    public void StartTask2()
    {
        if (startTask1 == 2) 
        {
            startTask2 = 1;
            PlayerPrefs.SetInt("Task2", startTask2);
            PlayerPrefs.Save();
        }
    }

    public void StartTask3()
    {
        if (startTask2 == 2)
        {
            startTask3 = 1;
            PlayerPrefs.SetInt("Task3", startTask3);
            PlayerPrefs.Save();
        }
    }
}