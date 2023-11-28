using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMeneger : MonoBehaviour
{
    private void Start()
    {        
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            Invoke("load", 6);
            PlayerPrefs.DeleteAll();
        }
    }

    void load()
    {
        SceneManager.LoadScene(1);
    }

    public void StartGame()
    {
        FindObjectOfType<VideoStart>().StartVideo();
        Invoke("loadGame", 2);
    }

    void loadGame()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadSetings()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadInstruction()
    {
        SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
