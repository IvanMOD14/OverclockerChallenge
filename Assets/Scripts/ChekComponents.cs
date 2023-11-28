using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ChekComponents : MonoBehaviour
{
    int tr;
    bool chek;
    bool ddr = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        if (Task.task1 == true)
        {
            if (other.gameObject.name == "GTX_1050TI_1" || other.gameObject.name == "RTX_3090_2")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
            }

            if (other.gameObject.name == "I3-10100F_1" || other.gameObject.name == "I7-12700F_2")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
            }

            if (other.gameObject.name == "DDR4_4gb_1" || other.gameObject.name == "DDR4_8gb_2" || other.gameObject.name == "DDR4_16gb_3")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
                if (ddr == true)
                {
                    Task.AllComponent -= 1;
                }
                ddr = true;
            }

            if (other.gameObject.name == "SSD_500gb_1" || other.gameObject.name == "HDD_1tb_1")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
            }

            if (other.gameObject.name == "PSU_300W_1" || other.gameObject.name == "PSU_600W_2")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
            }

            if (other.gameObject.name == "LGA_1200_1" || other.gameObject.name == "LGA_1700_2")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
            }

            if (other.gameObject.name == "Stenka_Ñlosed_1" || other.gameObject.name == "Stenka_Open_2")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
            }

            if (other.gameObject.name == "Culler_TDP120w_1" || other.gameObject.name == "Culler_TDP180w_2")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
            }

            if (other.gameObject.name == "Vertushka-1_1" || other.gameObject.name == "Vertushka-2_2")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
            }

            if (Task.score >= 8 & Task.AllComponent >= 9)
            {
                chek = true;
            }
        }

        if (Task.task2 == true)
        {
            if (other.gameObject.name == "GTX_1050TI_1" || other.gameObject.name == "RTX_3090_2")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
            }

            if (other.gameObject.name == "I3-10100F_1" || other.gameObject.name == "I7-12700F_2")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
            }

            if (other.gameObject.name == "DDR4_4gb_1" || other.gameObject.name == "DDR4_8gb_2" || other.gameObject.name == "DDR4_16gb_3")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
                if (ddr == true)
                {
                    Task.AllComponent -= 1;
                }
                ddr = true;
            }

            if (other.gameObject.name == "SSD_500gb_1" || other.gameObject.name == "HDD_1tb_1")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
            }

            if (other.gameObject.name == "PSU_300W_1" || other.gameObject.name == "PSU_600W_2")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
            }

            if (other.gameObject.name == "LGA_1200_1" || other.gameObject.name == "LGA_1700_2")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
            }

            if (other.gameObject.name == "Stenka_Ñlosed_1" || other.gameObject.name == "Stenka_Open_2")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
            }

            if (other.gameObject.name == "Culler_TDP120w_1" || other.gameObject.name == "Culler_TDP180w_2")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
            }

            if (other.gameObject.name == "Vertushka-1_1" || other.gameObject.name == "Vertushka-2_2")
            {
                string lastChar = other.gameObject.name.Substring(other.gameObject.name.Length - 1);
                Task.score += Convert.ToInt32(lastChar);
                Task.AllComponent += 1;
            }

            if (Task.score >= 16 & Task.AllComponent >= 9)
            {
                chek = true;
            }
        }

        if (Task.task3 == true)
        {
            if (other.gameObject.name == "GTX_1050TI_1")
            {
                Task.score += 1;
            }

            if (other.gameObject.name == "I3-10100F_1")
            {
                Task.score += 1;
            }

            if (other.gameObject.name == "DDR4_4gb_1")
            {
                Task.score += 1;
            }

            if (other.gameObject.name == "SSD_1" || other.gameObject.name == "HDD_1tb_1")
            {
                Task.score += 1;
            }

            if (other.gameObject.name == "PSU_300W_1")
            {
                Task.score += 1;
            }

            if (other.gameObject.name == "LGA_1700_1")
            {
                Task.score += 1;
            }

            if (other.gameObject.name == "Stenka_Ñlosed_1")
            {
                Task.score += 1;
            }

            if (other.gameObject.name == "Culler_TDP120w_1")
            {
                Task.score += 1;
            }

            if (other.gameObject.name == "Vertushka-1_1")
            {
                Task.score += 1;
            }
        }

        tr = Task.score;
        Debug.Log(tr);
    }

    private void OnTriggerStay(Collider other)
    {
        if (chek == true)
        {
            Destroy(other.gameObject);
        }
    }
}
