using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ChekComponents : MonoBehaviour
{
    int tr;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        if (Task.task1 == true)
        {
            if (other.gameObject.name == "GPU_1")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
            }

            if (other.gameObject.name == "CPU_1")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
            }

            if (other.gameObject.name == "DDR4_1")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
            }

            if (other.gameObject.name == "SSD_1" || other.gameObject.name == "HDD_1")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
            }

            if (other.gameObject.name == "PSU_1")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
            }

            if (other.gameObject.name == "LGA_1")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
            }

            if (other.gameObject.name == "Stenka_1")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
            }

            if (other.gameObject.name == "Culler_1")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
            }

            if (other.gameObject.name == "Vertushka_1")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
            }
        }

        if (Task.task2 == true)
        {
            if (other.gameObject.name == "GPU_1")
            {
                Task.score += 1;
            }

            if (other.gameObject.name == "CPU_1")
            {
                Task.score += 1;
            }

            if (other.gameObject.name == "DDR4_1")
            {
                Task.score += 1;
            }

            if (other.gameObject.name == "SSD_1" || other.gameObject.name == "HDD_1")
            {
                Task.score += 1;
            }

            if (other.gameObject.name == "PSU_1")
            {
                Task.score += 1;
            }

            if (other.gameObject.name == "LGA_1")
            {
                Task.score += 1;
            }

            if (other.gameObject.name == "Stenka_1")
            {
                Task.score += 1;
            }

            if (other.gameObject.name == "Culler_1")
            {
                Task.score += 1;
            }

            if (other.gameObject.name == "Vertushka_1")
            {
                Task.score += 1;
            }
        }

        if (Task.task3 == true)
        {
            if (other.gameObject.name == "GPU_1")
            {
                Task.score += 1;
            }

            if (other.gameObject.name == "CPU_1")
            {
                Task.score += 1;
            }

            if (other.gameObject.name == "DDR4_1")
            {
                Task.score += 1;
            }

            if (other.gameObject.name == "SSD_1" || other.gameObject.name == "HDD_1")
            {
                Task.score += 1;
            }

            if (other.gameObject.name == "PSU_1")
            {
                Task.score += 1;
            }

            if (other.gameObject.name == "LGA_1")
            {
                Task.score += 1;
            }

            if (other.gameObject.name == "Stenka_1")
            {
                Task.score += 1;
            }

            if (other.gameObject.name == "Culler_1")
            {
                Task.score += 1;
            }

            if (other.gameObject.name == "Vertushka_1")
            {
                Task.score += 1;
            }
        }

        tr = Task.score;
        Debug.Log(tr);
    }
}
