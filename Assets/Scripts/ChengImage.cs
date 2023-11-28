using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Video;

public class ChengImage : MonoBehaviour
{
    public GameObject endCanvas;
    public Image image;
    public TMP_Text imageText;
    public float fadeDuration = 2.0f;

    private void Start()
    {
        image.enabled = true;
        StartCoroutine(FadeImageStart(1.0f, 0.0f, fadeDuration));
    }

    IEnumerator FadeImageStart(float startAlpha, float endAlpha, float duration)
    {
        Color color = image.color;
        float timePassed = 0.0f;

        while (timePassed < duration)
        {
            color.a = Mathf.Lerp(startAlpha, endAlpha, timePassed / duration);
            image.color = color;
            timePassed += Time.deltaTime;
            yield return null;
        }

        color.a = endAlpha;
        image.color = color;
        image.enabled = false;
    }

    public void EndVideo()
    {
        StartCoroutine(FadeImage(0.0f, 1.0f, fadeDuration));
        image.enabled = true;
    }

    IEnumerator FadeImage(float startAlpha, float endAlpha, float duration)
    {
        Color color = image.color;
        float timePassed = 0.0f;

        while (timePassed < duration)
        {
            color.a = Mathf.Lerp(startAlpha, endAlpha, timePassed / duration);
            image.color = color;
            timePassed += Time.deltaTime;
            yield return null;
        }

        color.a = endAlpha;
        image.color = color;
        FindObjectOfType<VideoStart>().StartVideo();
        Invoke("End", 8f);
    }
    void End()
    {
        endCanvas.SetActive(true);
        StartCoroutine(FadeImageText(0.0f, 1.0f, 5f));
        Invoke("Exit", 8f);
    }

    IEnumerator FadeImageText(float startAlpha, float endAlpha, float duration)
    {
        Color color = imageText.color;
        float timePassed = 0.0f;

        while (timePassed < duration)
        {
            color.a = Mathf.Lerp(startAlpha, endAlpha, timePassed / duration);
            imageText.color = color;
            timePassed += Time.deltaTime;
            yield return null;
        }

        color.a = endAlpha;
        imageText.color = color;
    }

    void Exit()
    {
        Application.Quit();
    }
}
