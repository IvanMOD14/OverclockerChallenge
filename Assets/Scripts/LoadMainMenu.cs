using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class LoadMainMenu : MonoBehaviour
{
    public PlayableDirector loadScene;
    int a;

    void Start()
    {
        a = PlayerPrefs.GetInt("SavedInteger");

        if (SceneManager.GetActiveScene().buildIndex == 0 & a == 0)
        {
            loadScene = GetComponent<PlayableDirector>();
            loadScene.Play();
            a++;
            PlayerPrefs.SetInt("SavedInteger", a);
            PlayerPrefs.Save();
        }
    }

    void Update()
    {
        
    }
}
