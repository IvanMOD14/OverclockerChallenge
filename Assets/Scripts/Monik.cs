using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monik : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;

    public GameObject task1;
    public GameObject task2;
    public GameObject task3;

    public GameObject taskMenu;

    public void Exit()
    {
        camera1.enabled = true;
        camera2.enabled = false;
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
        task1.SetActive(true);
        taskMenu.SetActive(false);
    }

    public void Task2()
    {
        task2.SetActive(true);
        taskMenu.SetActive(false);
    }

    public void Task3()
    {
        task3.SetActive(true);
        taskMenu.SetActive(false);
    }
}
