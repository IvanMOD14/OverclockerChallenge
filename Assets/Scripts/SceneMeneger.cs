using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMeneger : MonoBehaviour
{
    private void Start()
    {        
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            Invoke("load", 5);
            PlayerPrefs.DeleteAll();
        }
    }

    void load()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadSetings()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadInstruction()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
