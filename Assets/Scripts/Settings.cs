using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Slider slider1;
    public Slider slider2;
    public Slider slider3;
    public Slider slider4;
    public Slider slider5;

    public AudioSource audioSource;

    private void Update()
    {
        audioSource.volume = slider1.value;
        AddFunctions.MoveSpeedMax = slider2.value;
        AddFunctions.MoveSpeedMin = slider3.value;
        AddFunctions.cameraSensitivityMax = slider4.value;
        AddFunctions.cameraSensitivityMin = slider5.value;
    }
}
