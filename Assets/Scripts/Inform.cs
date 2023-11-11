using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inform : MonoBehaviour
{
    public GameObject st1;
    public GameObject st2;
    public GameObject st3;

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
        SceneManager.LoadScene(1);
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
