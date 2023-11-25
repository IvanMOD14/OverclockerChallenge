using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddFunctions : MonoBehaviour
{
    int chekCamera = 0;
    public static int chekMove = 0;
    public static float MoveSpeedMin = 0;
    public static float MoveSpeedMax = 0;
    public static float cameraSensitivityMin = 0;
    public static float cameraSensitivityMax = 0;

    public GameObject player;
    public void cameraSen()
    {
        switch (chekCamera)
        {
            case 0:
                PlayerController.cameraSensitivity = cameraSensitivityMin;
                chekCamera++;
                break;
            case 1:
                PlayerController.cameraSensitivity = cameraSensitivityMax;
                chekCamera--;
                break;
        }
    }

    public void moveSpeed()
    {
        switch (chekMove)
        {
            case 0:
                PlayerController.Speed = MoveSpeedMin;
                player.transform.localScale = new Vector3(player.transform.localScale.x, 0.7f, player.transform.localScale.z);
                chekMove++;
                break;
            case 1:
                PlayerController.Speed = MoveSpeedMax;
                player.transform.localScale = new Vector3(player.transform.localScale.x, 1.2f, player.transform.localScale.z);
                chekMove--;
                break;
        }
    }
}
