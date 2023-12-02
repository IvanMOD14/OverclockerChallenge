using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class MousController : MonoBehaviour
{
    public Transform playerBody;
    public GameObject hand;

    public float sens = 200f;
    public float rast = 10f;
    public static int maney = 1000;
    
    public Transform pointer;
    public GameObject pointerObject;
    private GameObject item;
    private bool chek = false;
    private bool chekHand = false;
    private int number;

    public Camera camera1;
    public Camera camera2;
    public GameObject canvas;

    public Text textManey;
    public TMP_Text activItem;

    GameObject door;

    public GameObject tableCorpus;

    bool buttonClik;

    public static bool payComponent;

    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        camera1.enabled = true;
        camera2.enabled = false;
        pointerObject.SetActive(true);
        Debug.Log("1");
    }

    public void ButtonClik()
    {
        buttonClik = true;
    }

    void Update()
    {
        //float mX = Input.GetAxis("Mouse X") * sens * Time.deltaTime;
        //float mY = Input.GetAxis("Mouse Y") * sens * Time.deltaTime;

        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * rast, Color.yellow);

        RaycastHit hit;

        textManey.text = maney.ToString();
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.layer == LayerMask.NameToLayer("ActivItem"))
            {
                activItem.text = hit.collider.gameObject.name[..^2];
            }

            else
            {
                activItem.text = "";
            }
        }

        if (buttonClik == true)
        {
            if (Physics.Raycast(ray, out hit))
            {
                buttonClik = false;

                if (hit.collider.CompareTag("Monitor"))
                {
                    camera1.enabled = false;
                    camera2.enabled = true;
                    pointerObject.SetActive(false);
                    canvas.SetActive(false);

                    Debug.Log("2");
                }

                if (hit.collider.CompareTag("Pickup") & chekHand == false)
                {
                    chek = true;
                    item = hit.collider.gameObject;

                    Debug.Log(item.tag);
                }

                if (hit.collider.CompareTag("ChekTableCorpus") & item.name == "Corpus_1")
                {
                    tableCorpus.GetComponent<BoxCollider>().enabled = true;

                    item.transform.parent = hit.collider.gameObject.transform;
                    item.GetComponent<Rigidbody>().isKinematic = true;
                    item.GetComponent<Collider>().isTrigger = false;
                    item.transform.position = hit.collider.gameObject.transform.position;

                    float x = hit.collider.gameObject.transform.localScale.x;
                    float y = hit.collider.gameObject.transform.localScale.y;
                    float z = hit.collider.gameObject.transform.localScale.z;
                    item.transform.localScale = new Vector3(1f / x, 1f / y, 1f / z);
                    item.transform.localPosition = new Vector3(0, 0.42f, 0);

                    Vector3 surfaceNormal = hit.normal;
                    Quaternion surfaceRotation = Quaternion.FromToRotation(item.transform.up, surfaceNormal);
                    item.transform.rotation = surfaceRotation * item.transform.rotation;
                    item.transform.rotation = new Quaternion(0, 90, 0, 90);

                    //item.transform.position = hit.point + Vector3.up * 0.1f;
                    chekHand = false;
                    Debug.Log(item.tag);
                }

                if (chekHand == false & hit.collider.gameObject.layer == LayerMask.NameToLayer("Box"))
                {
                    chek = true;
                    item = hit.collider.gameObject;
                    Debug.Log("LOL");
                }

                if (hit.collider.CompareTag("door"))
                {
                    if (AnimDors.chekDoorHous == true & hit.collider.name == "DoorHouse")
                    {
                        AnimDors.chekDoorHous = false;
                        door = GameObject.Find("DoorHouse");
                        AnimDors script = door.GetComponent<AnimDors>();
                        script.OpenDorsHous();
                        return;
                    }

                    if (AnimDors.chekDoorHous == false & hit.collider.name == "DoorHouse")
                    {
                        AnimDors.chekDoorHous = true;
                        door = GameObject.Find("DoorHouse");
                        AnimDors script = door.GetComponent<AnimDors>();
                        script.OpenDorsHous();
                        return;
                    }
                    
                    if (AnimDors.chekDoorShop1 == true & hit.collider.name == "DoorShop1")
                    {
                        AnimDors.chekDoorShop1 = false;
                        door = GameObject.Find("DoorShop1");
                        AnimDors script = door.GetComponent<AnimDors>();
                        script.OpenDorsShop1();
                        return;
                    }

                    if (AnimDors.chekDoorShop1 == false & hit.collider.name == "DoorShop1")
                    {
                        AnimDors.chekDoorShop1 = true;
                        door = GameObject.Find("DoorShop1");
                        AnimDors script = door.GetComponent<AnimDors>();
                        script.OpenDorsShop1();
                        return;
                    }

                    if (AnimDors.chekDoorShop2 == true & hit.collider.name == "DoorShop2")
                    {
                        AnimDors.chekDoorShop2 = false;
                        door = GameObject.Find("DoorShop2");
                        AnimDors script = door.GetComponent<AnimDors>();
                        script.OpenDorsShop2();
                        return;
                    }

                    if (AnimDors.chekDoorShop2 == false & hit.collider.name == "DoorShop2")
                    {
                        AnimDors.chekDoorShop2 = true;
                        door = GameObject.Find("DoorShop2");
                        AnimDors script = door.GetComponent<AnimDors>();
                        script.OpenDorsShop2();
                        return;
                    }
                }

                if (hit.collider.CompareTag("PickupPay"))
                {
                    chek = true;
                    item = hit.collider.gameObject; 
                    Debug.Log(item.tag);
                }

                if (hit.collider.CompareTag("Materinka") & chekHand == true & item.tag != "PickupPay" & (item.name == "LGA_1200_1" || item.name == "LGA_1700_2"))
                {
                    item.transform.parent = hit.collider.gameObject.transform;
                    item.GetComponent<Rigidbody>().isKinematic = true;
                    item.GetComponent<Collider>().isTrigger = false;
                    item.transform.position = hit.collider.gameObject.transform.position;

                    Vector3 surfaceNormal = hit.normal;
                    Quaternion surfaceRotation = Quaternion.FromToRotation(item.transform.up, surfaceNormal);
                    item.transform.rotation = surfaceRotation * item.transform.rotation;
                    item.transform.rotation = new Quaternion(90, 90, -90, 90);


                    //item.transform.position = hit.point + Vector3.up * 0.1f;
                    chekHand = false;
                    Debug.Log(item.tag);
                }

                if (hit.collider.CompareTag("Stenka") & chekHand == true & item.tag != "PickupPay" & (item.name == "Stenka_Ñlosed_1" || item.name == "Stenka_Open_2"))
                {
                    item.transform.parent = hit.collider.gameObject.transform;
                    item.GetComponent<Rigidbody>().isKinematic = true;
                    item.GetComponent<Collider>().isTrigger = false;
                    item.transform.position = hit.collider.gameObject.transform.position;
                    item.transform.rotation = hit.collider.gameObject.transform.rotation;

                    //item.transform.position = hit.point + Vector3.up * 0.1f;
                    chekHand = false;
                    Debug.Log(item.tag);
                }

                if (hit.collider.CompareTag("GPU") & chekHand == true & item.tag != "PickupPay" & (item.name == "GTX_1050TI_1" || item.name == "RTX_3090_2"))
                {
                    item.transform.parent = hit.collider.gameObject.transform;
                    item.GetComponent<Rigidbody>().isKinematic = true;
                    item.GetComponent<Collider>().isTrigger = false;
                    item.transform.position = hit.collider.gameObject.transform.position;
                    item.transform.rotation = hit.collider.gameObject.transform.rotation;

                    //item.transform.position = hit.point + Vector3.up * 0.1f;
                    chekHand = false;
                    Debug.Log(item.tag);
                }

                if (hit.collider.CompareTag("CPU") & chekHand == true & item.tag != "PickupPay" & (item.name == "I3-10100F_1" || item.name == "I7-12700F_2"))
                {
                    item.transform.parent = hit.collider.gameObject.transform;
                    item.GetComponent<Rigidbody>().isKinematic = true;
                    item.GetComponent<Collider>().isTrigger = false;
                    item.transform.position = hit.collider.gameObject.transform.position;
                    item.transform.rotation = hit.collider.gameObject.transform.rotation;

                    //item.transform.position = hit.point + Vector3.up * 0.1f;
                    chekHand = false;
                    Debug.Log(item.tag);
                }

                if ((hit.collider.name == "I3-10100F_1" || hit.collider.name == "I7-12700F_2") & chekHand == true & item.tag != "PickupPay" & (item.name == "Culler_TDP120w_1" || item.name == "Culler_TDP180w_2"))
                {
                    item.transform.parent = hit.collider.gameObject.transform;
                    item.GetComponent<Rigidbody>().isKinematic = true;
                    item.GetComponent<Collider>().isTrigger = false;
                    item.transform.position = hit.collider.gameObject.transform.position;
                    item.transform.rotation = hit.collider.gameObject.transform.rotation;

                    //item.transform.position = hit.point + Vector3.up * 0.1f;
                    chekHand = false;
                    Debug.Log(item.tag);
                }
                
                if (hit.collider.CompareTag("DDR") & chekHand == true & item.tag != "PickupPay" & (item.name == "DDR4_4gb_1" || item.name == "DDR4_8gb_2" || item.name == "DDR4_16gb_3"))
                {
                    item.transform.parent = hit.collider.gameObject.transform;
                    item.GetComponent<Rigidbody>().isKinematic = true;
                    item.GetComponent<Collider>().isTrigger = false;
                    item.transform.position = hit.collider.gameObject.transform.position;
                    item.transform.rotation = hit.collider.gameObject.transform.rotation;

                    //item.transform.position = hit.point + Vector3.up * 0.1f;
                    chekHand = false;
                    Debug.Log(item.tag);
                }

                if (hit.collider.CompareTag("PSU") & chekHand == true & item.tag != "PickupPay" & (item.name == "PSU_300W_1" || item.name == "PSU_600W_2"))
                {
                    item.transform.parent = hit.collider.gameObject.transform;
                    item.GetComponent<Rigidbody>().isKinematic = true;
                    item.GetComponent<Collider>().isTrigger = false;
                    item.transform.position = hit.collider.gameObject.transform.position;

                    Vector3 surfaceNormal = hit.normal;
                    Quaternion surfaceRotation = Quaternion.FromToRotation(item.transform.up, surfaceNormal);
                    item.transform.rotation = surfaceRotation * item.transform.rotation;
                    item.transform.rotation = new Quaternion(0, 90, 0, 0);

                    //item.transform.position = hit.point + Vector3.up * 0.1f;
                    chekHand = false;
                    Debug.Log(item.tag);
                }

                if (hit.collider.CompareTag("Vertushka") & chekHand == true & item.tag != "PickupPay" & (item.name == "Vertushka-1_1" || item.name == "Vertushka-2_2"))
                {
                    item.transform.parent = hit.collider.gameObject.transform;
                    item.GetComponent<Rigidbody>().isKinematic = true;
                    item.GetComponent<Collider>().isTrigger = false;
                    item.transform.position = hit.collider.gameObject.transform.position;

                    Vector3 surfaceNormal = hit.normal;
                    Quaternion surfaceRotation = Quaternion.FromToRotation(item.transform.up, surfaceNormal);
                    item.transform.rotation = surfaceRotation * item.transform.rotation;
                    item.transform.rotation = new Quaternion(90, 0, 0, 90);

                    //item.transform.position = hit.point + Vector3.up * 0.1f;
                    chekHand = false;
                    Debug.Log(item.tag);
                }

                if (hit.collider.CompareTag("HDD") & chekHand == true & item.tag != "PickupPay" & (item.name == "HDD_1tb_1" || item.name == "SSD_500gb_1"))
                {
                    item.transform.parent = hit.collider.gameObject.transform;
                    item.GetComponent<Rigidbody>().isKinematic = true;
                    item.GetComponent<Collider>().isTrigger = false;
                    item.transform.position = hit.collider.gameObject.transform.position;

                    Vector3 surfaceNormal = hit.normal;
                    Quaternion surfaceRotation = Quaternion.FromToRotation(item.transform.up, surfaceNormal);
                    item.transform.rotation = surfaceRotation * item.transform.rotation;
                    item.transform.rotation = new Quaternion(0, 90, 0, 90);

                    //item.transform.position = hit.point + Vector3.up * 0.1f;
                    chekHand = false;
                    Debug.Log(item.tag);
                }

                /*if (hit.collider.CompareTag("TableCorpus") & chekHand == true & item.tag != "PickupPay" & (item.name == "Corpus_1" || item.name == "Corpus_2"))
                {
                    item.transform.parent = hit.collider.gameObject.transform;
                    item.GetComponent<Rigidbody>().isKinematic = true;
                    item.GetComponent<Collider>().isTrigger = false;
                    item.transform.position = hit.collider.gameObject.transform.position;

                    float x = hit.collider.gameObject.transform.localScale.x;
                    float y = hit.collider.gameObject.transform.localScale.y;
                    float z = hit.collider.gameObject.transform.localScale.z;
                    item.transform.localScale = new Vector3(1f / x, 1f / y, 1f / z);
                    item.transform.localPosition = new Vector3(0, 0.42f, 0);

                    Vector3 surfaceNormal = hit.normal;
                    Quaternion surfaceRotation = Quaternion.FromToRotation(item.transform.up, surfaceNormal);
                    item.transform.rotation = surfaceRotation * item.transform.rotation;
                    item.transform.rotation = new Quaternion(0, 90, 0, 90);

                    //item.transform.position = hit.point + Vector3.up * 0.1f;
                    chekHand = false;
                    Debug.Log(item.tag);
                }*/

                else if (hit.collider.CompareTag("Table") & chekHand == true & (item.name != "Stenka_Ñlosed_1" & item.name != "Stenka_Open_2") & (item.name != "Corpus_1" & item.name != "Corpus_2"))
                {
                    item.transform.parent = hit.collider.gameObject.transform;
                    float x = hit.collider.gameObject.transform.localScale.x;
                    float y = hit.collider.gameObject.transform.localScale.y;
                    float z = hit.collider.gameObject.transform.localScale.z;
                    item.transform.localScale = new Vector3(1f / x, 1f / y, 1f / z);
                    item.GetComponent<Rigidbody>().isKinematic = true;
                    item.GetComponent<Collider>().isTrigger = false;
                    //item.transform.position = hit.collider.gameObject.transform.position;

                    Vector3 surfacePoint = hit.point;
                    Vector3 surfaceNormal = hit.normal;
                    item.transform.position = surfacePoint;
                    Quaternion surfaceRotation = Quaternion.FromToRotation(item.transform.up, surfaceNormal);
                    item.transform.rotation = surfaceRotation * item.transform.rotation;

                    //item.transform.position = hit.point + Vector3.up * 0.1f;
                    chekHand = false;
                    Debug.Log(item.tag);
                }

                else if (hit.collider.CompareTag("Pol") & chekHand == true & (item.name != "Stenka_Ñlosed_1" & item.name != "Stenka_Open_2") & (item.name != "Corpus_1" & item.name != "Corpus_2") & hit.collider.transform.localScale == new Vector3(0.01f, 0.01f, 0.01f))
                {
                    item.transform.parent = hit.collider.gameObject.transform;
                    float x = hit.collider.gameObject.transform.localScale.x;
                    float y = hit.collider.gameObject.transform.localScale.y;
                    float z = hit.collider.gameObject.transform.localScale.z;
                    item.transform.localScale = new Vector3(0.01f / x, 0.01f / y, 0.01f / z);
                    item.GetComponent<Rigidbody>().isKinematic = true;
                    item.GetComponent<Collider>().isTrigger = false;
                    //item.transform.position = hit.collider.gameObject.transform.position;

                    Vector3 surfacePoint = hit.point;
                    Vector3 surfaceNormal = hit.normal;
                    item.transform.position = surfacePoint;
                    Quaternion surfaceRotation = Quaternion.FromToRotation(item.transform.up, surfaceNormal);
                    item.transform.rotation = surfaceRotation * item.transform.rotation;

                    //item.transform.position = hit.point + Vector3.up * 0.1f;
                    chekHand = false;
                    Debug.Log(item.tag);
                }

                else if (hit.collider.CompareTag("Pol") & chekHand == true & (item.name != "Stenka_Ñlosed_1" & item.name != "Stenka_Open_2") & (item.name != "Corpus_1" & item.name != "Corpus_2") & hit.collider.transform.localScale == new Vector3(1f, 1f, 1f))
                {
                    item.transform.parent = hit.collider.gameObject.transform;
                    float x = hit.collider.gameObject.transform.localScale.x;
                    float y = hit.collider.gameObject.transform.localScale.y;
                    float z = hit.collider.gameObject.transform.localScale.z;
                    item.transform.localScale = new Vector3(1f / x, 1f / y, 1f / z);
                    item.GetComponent<Rigidbody>().isKinematic = true;
                    item.GetComponent<Collider>().isTrigger = false;
                    //item.transform.position = hit.collider.gameObject.transform.position;

                    Vector3 surfacePoint = hit.point;
                    Vector3 surfaceNormal = hit.normal;
                    item.transform.position = surfacePoint;
                    Quaternion surfaceRotation = Quaternion.FromToRotation(item.transform.up, surfaceNormal);
                    item.transform.rotation = surfaceRotation * item.transform.rotation;

                    //item.transform.position = hit.point + Vector3.up * 0.1f;
                    chekHand = false;
                    Debug.Log(item.tag);
                }

                else if (hit.collider.CompareTag("Table") & chekHand == true & (item.name == "Stenka_Ñlosed_1" || item.name == "Stenka_Open_2"))
                {
                    item.transform.parent = hit.collider.gameObject.transform;
                    float x = hit.collider.gameObject.transform.localScale.x;
                    float y = hit.collider.gameObject.transform.localScale.y;
                    float z = hit.collider.gameObject.transform.localScale.z;
                    item.transform.localScale = new Vector3(100f / x, 100f / y, 100f / z);
                    item.GetComponent<Rigidbody>().isKinematic = true;
                    item.GetComponent<Collider>().isTrigger = false;
                    //item.transform.position = hit.collider.gameObject.transform.position;

                    Vector3 surfacePoint = hit.point;
                    Vector3 surfaceNormal = hit.normal;
                    item.transform.position = surfacePoint;
                    Quaternion surfaceRotation = Quaternion.FromToRotation(item.transform.up, surfaceNormal);
                    item.transform.rotation = surfaceRotation * item.transform.rotation;

                    //item.transform.position = hit.point + Vector3.up * 0.1f;
                    chekHand = false;
                    Debug.Log(item.tag);
                }

                if (hit.collider.CompareTag("Pay") & item.gameObject.tag == "PickupPay")
                {
                    if (item.gameObject.name == "GTX_1050TI_1" || item.gameObject.name == "RTX_3090_2")
                    {
                        string lastChar = item.gameObject.name.Substring(item.gameObject.name.Length - 1);
                        number = Convert.ToInt32(lastChar);
                        if (number == 1 & maney >= 300)
                        {
                            maney -= 300;
                            item.gameObject.tag = "Pickup";
                        }

                        if (number == 2 & maney >= 400)
                        {
                            maney -= 400;
                            item.gameObject.tag = "Pickup";
                        }
                    }

                    if (item.gameObject.name == "I3-10100F_1" || item.gameObject.name == "I7-12700F_2")
                    {
                        string lastChar = item.gameObject.name.Substring(item.gameObject.name.Length - 1);
                        number = Convert.ToInt32(lastChar);
                        if (number == 1 & maney >= 100)
                        {
                            maney -= 100;
                            item.gameObject.tag = "Pickup";
                        }

                        if (number == 2 & maney >= 200)
                        {
                            maney -= 200;
                            item.gameObject.tag = "Pickup";
                        }
                    }

                    if (item.name == "DDR4_4gb_1" || item.name == "DDR4_8gb_2" || item.name == "DDR4_16gb_3")
                    {
                        string lastChar = item.gameObject.name.Substring(item.gameObject.name.Length - 1);
                        number = Convert.ToInt32(lastChar);
                        if (number == 1 & maney >= 50)
                        {
                            maney -= 50;
                            item.gameObject.tag = "Pickup";
                        }

                        if (number == 2 & maney >= 80)
                        {
                            maney -= 80;
                            item.gameObject.tag = "Pickup";
                        }

                        if (number == 3 & maney >= 120)
                        {
                            maney -= 120;
                            item.gameObject.tag = "Pickup";
                        }
                    }

                    if (item.gameObject.name == "SSD_500gb_1" || item.gameObject.name == "HDD_1tb_1")
                    {
                        string lastChar = item.gameObject.name.Substring(item.gameObject.name.Length - 1);
                        number = Convert.ToInt32(lastChar);
                        if (number == 1 & maney >= 60)
                        {
                            maney -= 60;
                            item.gameObject.tag = "Pickup";
                        }

                        if (number == 2 & maney >= 90)
                        {
                            maney -= 90;
                            item.gameObject.tag = "Pickup";
                        }
                    }

                    if (item.gameObject.name == "PSU_300W_1" || item.gameObject.name == "PSU_600W2")
                    {
                        string lastChar = item.gameObject.name.Substring(item.gameObject.name.Length - 1);
                        number = Convert.ToInt32(lastChar);
                        if (number == 1 & maney >= 120)
                        {
                            maney -= 120;
                            item.gameObject.tag = "Pickup";
                        }

                        if (number == 2 & maney >= 180)
                        {
                            maney -= 180;
                            item.gameObject.tag = "Pickup";
                        }
                    }

                    if (item.gameObject.name == "LGA_1200_1" || item.gameObject.name == "LGA_1700_2")
                    {
                        string lastChar = item.gameObject.name.Substring(item.gameObject.name.Length - 1);
                        number = Convert.ToInt32(lastChar);
                        if (number == 1 & maney >= 90)
                        {
                            maney -= 90;
                            item.gameObject.tag = "Pickup";
                        }

                        if (number == 2 & maney >= 140)
                        {
                            maney -= 140;
                            item.gameObject.tag = "Pickup";
                        }
                    }

                    if (item.gameObject.name == "Corpus_1" || item.gameObject.name == "Corpus_2")
                    {
                        string lastChar = item.gameObject.name.Substring(item.gameObject.name.Length - 1);
                        number = Convert.ToInt32(lastChar);
                        if (number == 1 & maney >= 70)
                        {
                            maney -= 70;
                            item.gameObject.tag = "Pickup";
                        }

                        if (number == 2 & maney >= 100)
                        {
                            maney -= 100;
                            item.gameObject.tag = "Pickup";
                        }
                    }

                    if (item.gameObject.name == "Culler_TDP120w_1" || item.gameObject.name == "Culler_TDP180w_2")
                    {
                        string lastChar = item.gameObject.name.Substring(item.gameObject.name.Length - 1);
                        number = Convert.ToInt32(lastChar);
                        if (number == 1 & maney >= 30)
                        {
                            maney -= 30;
                            item.gameObject.tag = "Pickup";
                        }

                        if (number == 2 & maney >= 50)
                        {
                            maney -= 50;
                            item.gameObject.tag = "Pickup";
                        }
                    }

                    if (item.gameObject.name == "Vertushka-1_1" || item.gameObject.name == "Vertushka-2_2")
                    {
                        string lastChar = item.gameObject.name.Substring(item.gameObject.name.Length - 1);
                        number = Convert.ToInt32(lastChar);
                        if (number == 1 & maney >= 20)
                        {
                            maney -= 20;
                            item.gameObject.tag = "Pickup";
                        }

                        if (number == 2 & maney >= 35)
                        {
                            maney -= 35;
                            item.gameObject.tag = "Pickup";
                        }
                    }
                }

                else
                {
                    buttonClik = false;
                    return;
                }

            }
        }

        /*if (Input.GetKeyDown(KeyCode.Q))
        {
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Pickup") & chekHand == false)
                {
                    chek = true;
                }
            }
        }*/

        if (Physics.Raycast(ray, out hit))
        {
            pointer.position = hit.point;

            if(chek == true)
            {
                item.transform.parent = hand.transform;

                item.transform.position = hand.transform.position;

                item.GetComponent<Rigidbody>().isKinematic = true;
                item.GetComponent<Collider>().isTrigger = true;

                //string ObjectName = hit.collider.name;

                //Destroy(GameObject.Find(ObjectName));

                chek = false;
                chekHand = true;

                //hit.collider.gameObject.transform.position = playerBody.position + new Vector3(5,5,0);
            }
        }

        //xRotation -= mY;
        //xRotation = Mathf.Clamp(xRotation, -90f, 90f);



        //transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        //playerBody.Rotate(Vector3.up * mX);
    }
}
