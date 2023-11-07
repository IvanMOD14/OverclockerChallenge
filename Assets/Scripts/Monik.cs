using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monik : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;

    public void Exit()
    {
        camera1.enabled = true;
        camera2.enabled = false;
    }
}
