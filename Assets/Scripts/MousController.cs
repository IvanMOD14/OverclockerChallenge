using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MousController : MonoBehaviour
{
    public Transform playerBody;
    public GameObject hand;

    public float sens = 200f;
    public float rast = 10f;
    public int maney = 100;
    
    public Transform pointer;
    private GameObject item;
    private bool chek = false;
    private bool chekHand = false;

    public Camera camera1;
    public Camera camera2;

    bool buttonClik;

    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        camera1.enabled = true;
        camera2.enabled = false;
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
        
        if (buttonClik == true)
        {
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Monitor"))
                {
                    camera1.enabled = false;
                    camera2.enabled = true;
                    Debug.Log("2");
                }

                if (hit.collider.CompareTag("Pickup") & chekHand == false)
                {
                    chek = true;
                    item = hit.collider.gameObject;

                    Debug.Log(item.tag);
                }

                if (hit.collider.CompareTag("PickupPay"))
                {
                    chek = true;
                    item = hit.collider.gameObject; 
                    Debug.Log(item.tag);
                }

                if (hit.collider.CompareTag("Materinka") & chekHand == true & item.tag != "PickupPay" & item.name == "Materinka")
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

                if (hit.collider.CompareTag("Stenka") & chekHand == true & item.tag != "PickupPay" & item.name == "Stenka")
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

                if (hit.collider.CompareTag("GPU") & chekHand == true & item.tag != "PickupPay" & item.name == "GPU")
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

                if (hit.collider.CompareTag("CPU") & chekHand == true & item.tag != "PickupPay" & item.name == "CPU")
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

                if (hit.collider.CompareTag("CPU") & chekHand == true & item.tag != "PickupPay" & item.name == "Culler")
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
                
                if (hit.collider.CompareTag("DDR") & chekHand == true & item.tag != "PickupPay" & item.name == "DDR")
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

                if (hit.collider.CompareTag("PSU") & chekHand == true & item.tag != "PickupPay" & item.name == "PSU")
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

                if (hit.collider.CompareTag("Vertushka") & chekHand == true & item.tag != "PickupPay" & item.name == "Vertushka")
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

                if (hit.collider.CompareTag("HDD") & chekHand == true & item.tag != "PickupPay" & item.name == "HDD")
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

                if (hit.collider.CompareTag("Table") & chekHand == true & item.tag != "PickupPay" & item.name == "Corpus")
                {
                    item.transform.parent = hit.collider.gameObject.transform;
                    item.GetComponent<Rigidbody>().isKinematic = true;
                    item.GetComponent<Collider>().isTrigger = false;
                    item.transform.position = hit.collider.gameObject.transform.position;

                    float x = hit.collider.gameObject.transform.localScale.x;
                    float y = hit.collider.gameObject.transform.localScale.y;
                    float z = hit.collider.gameObject.transform.localScale.z;
                    item.transform.localScale = new Vector3(1f / x, 1f / y, 1f / z);

                    Vector3 surfaceNormal = hit.normal;
                    Quaternion surfaceRotation = Quaternion.FromToRotation(item.transform.up, surfaceNormal);
                    item.transform.rotation = surfaceRotation * item.transform.rotation;
                    item.transform.rotation = new Quaternion(0, 90, 0, 90);

                    //item.transform.position = hit.point + Vector3.up * 0.1f;
                    chekHand = false;
                    Debug.Log(item.tag);
                }

                else if ((hit.collider.CompareTag("Table") || hit.collider.CompareTag("Pickup")) & chekHand == true & item.name != "Stenka")
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

                else if (hit.collider.CompareTag("Table") & chekHand == true & item.name == "Stenka")
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

                if (hit.collider.CompareTag("Pay") & maney >= 60)
                {
                    item.tag = "Pickup";
                    maney -= 50;
                    Debug.Log(item.tag);
                }

                else
                {
                    buttonClik = false;
                    return;
                }

                buttonClik = false;
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
