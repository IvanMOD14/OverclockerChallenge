using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inform : MonoBehaviour
{
    public GameObject st1;
    public GameObject st2;
    public GameObject st3;

    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvas3;

    int chek = 0;

    public void End()
    {
        if (chek > 0)
        {
            chek--;
        }
    }

    public void Past()
    {
        if (chek < 2)
        {
            chek++;
        }
    }

    public void Exit()
    {
        canvas1.SetActive(false); 
        canvas2.SetActive(false);
        canvas3.SetActive(true);
    }

    public void ExitMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void Information()
    {
        canvas1.SetActive(true);
        canvas2.SetActive(false);
        canvas3.SetActive(false);
    }

    public void Setings()
    {
        canvas1.SetActive(false);
        canvas2.SetActive(true);
        canvas3.SetActive(false);
        FindObjectOfType<AddFunctions>().moveSpeed();
        FindObjectOfType<AddFunctions>().moveSpeed();
        FindObjectOfType<AddFunctions>().cameraSen();
        FindObjectOfType<AddFunctions>().cameraSen();
    }

    private void Update()
    {
        switch (chek)
        {
            case 0:
                st1.SetActive(true);
                st2.SetActive(false);
                st3.SetActive(false);
                break;
            case 1:
                st1.SetActive(false);
                st2.SetActive(true);
                st3.SetActive(false);
                break;
            case 2:
                st1.SetActive(false);
                st2.SetActive(false);
                st3.SetActive(true);
                break;
        }
    }
}
