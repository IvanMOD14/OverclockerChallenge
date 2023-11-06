using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class MousController : MonoBehaviour
{
    public Transform playerBody;
    public GameObject hand;

    public float sens = 200f;
    public float rast = 10f;
    float xRotation = 0f;

    public Transform pointer;
    private GameObject item;
    private bool chek = false;
    private bool chekHand = false;


    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mX = Input.GetAxis("Mouse X") * sens * Time.deltaTime;
        float mY = Input.GetAxis("Mouse Y") * sens * Time.deltaTime;

        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * rast, Color.yellow);

        RaycastHit hit;

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Pickup") & chekHand == false)
                {
                    chek = true;
                }

                if (hit.collider.CompareTag("Materinka") & chekHand == true)
                {
                    item.transform.parent = hit.collider.gameObject.transform;
                    item.GetComponent<Rigidbody>().isKinematic = true;
                    //item.transform.position = hit.collider.gameObject.transform.position;
                    item.transform.rotation = hit.collider.gameObject.transform.rotation;
                    item.transform.position = hit.point + Vector3.up * 0.1f;
                    chekHand = false;
                }

                else if (hit.collider.CompareTag("Table") & chekHand == true)
                {
                    item.transform.parent = hit.collider.gameObject.transform;
                    float x = hit.collider.gameObject.transform.localScale.x;
                    float y = hit.collider.gameObject.transform.localScale.y;
                    float z = hit.collider.gameObject.transform.localScale.z;
                    item.transform.localScale = new Vector3(0.3f / x, 0.3f / y, 0.3f / z);
                    item.GetComponent<Rigidbody>().isKinematic = false;
                    //item.transform.position = hit.collider.gameObject.transform.position;
                    item.transform.rotation = hit.collider.gameObject.transform.rotation;
                    item.transform.position = hit.point + Vector3.up * 0.1f;
                    chekHand = false;
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
                item = hit.collider.gameObject;

                item.transform.parent = hand.transform;

                item.transform.position = hand.transform.position;

                item.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);

                item.GetComponent<Rigidbody>().isKinematic = true;

                //string ObjectName = hit.collider.name;

                //Destroy(GameObject.Find(ObjectName));

                chek = false;
                chekHand = true;

                //hit.collider.gameObject.transform.position = playerBody.position + new Vector3(5,5,0);
            }
        }

        xRotation -= mY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);



        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * mX);
    }
}