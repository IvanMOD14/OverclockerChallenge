using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChekComponents : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
    }
}
