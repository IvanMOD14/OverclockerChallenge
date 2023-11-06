using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SborkaPC : MonoBehaviour
{
    public GameObject GPU;
    public GameObject Culler;
    public GameObject DDR;

    private bool tekeItem = false;
    private string namee;

    private void Start()
    {
        GPU.SetActive(false);
        Culler.SetActive(false);
        DDR.SetActive(false);
    }

    public void Update()
    {
        if (namee == "GPU")
        {
            tekeItem = true;
        }
    }

    public void ActivGPU()
    {
        if (tekeItem == true)
        {
            GPU.SetActive(true);
        }
        
    }
    public void ActivCuller()
    {
        Culler.SetActive(true);
    }
    public void ActivDDR()
    {
        DDR.SetActive(true);
    }


    public void TakeItem()
    {
        
        //a = EventSystem.current.currentSelectedGameObject.name;
    }

    public void OnClicked(Button button)
    {
        namee = button.name;
        print(namee);
    }
}
