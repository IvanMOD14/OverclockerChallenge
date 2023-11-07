using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConektItem : MonoBehaviour
{
    bool isAttached = false;

    void Update()
    {
        if (!isAttached)
        {
            Ray ray = new Ray(transform.position, transform.forward);
            Debug.DrawRay(transform.position, transform.forward * 1f, Color.yellow);
            // ���������, ������ �� ������ �� ������ �����������
            RaycastHit hit;
            if (Physics.Raycast(transform.position, Vector3.down, out hit, 1.0f))
            {
                // ���� ������ ������ �� ������ �����������, ����������� ���
                transform.position = hit.point; // ���������� ������ �� ����� �������
                transform.rotation = Quaternion.FromToRotation(Vector3.up, hit.normal) * transform.rotation; // ������������ ������ ���, ����� �� �������� � �����������
                isAttached = true;
            }
        }
    }
}