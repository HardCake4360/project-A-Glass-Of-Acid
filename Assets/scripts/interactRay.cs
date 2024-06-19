using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactRay : MonoBehaviour
{
    [SerializeField] private float targetDistance = 10f; // ���� �Ÿ�
    [SerializeField] private float rotationSpeed = 100f; // ���� ȸ�� �ӵ�
    public GameObject camera; // ī�޶� ������Ʈ

    private void Update()
    {
        RaycastHit hit;

        // Raycast �߻�
        Vector3 rayDirection = camera.transform.forward; // ī�޶� ���� ���

        Debug.DrawRay(camera.transform.position, rayDirection * targetDistance, Color.green);

        if (Physics.Raycast(camera.transform.position, rayDirection, out hit, targetDistance))
        {
            // ������Ʈ ����
            if (hit.collider.tag == "Target") // ���� �±� ����
            {
                // Ư�� �޼��� ȣ��
                CallMethod(hit.collider.gameObject, rayDirection);
            }
        }
    }

    private void CallMethod(GameObject targetObject,Vector3 rayDirection)
    {
        // ���⿡ Ư�� �޼��� ���� �ۼ� (��: ��ȣ �ۿ� UI Ȱ��ȭ, ���� ǥ�� ��)
        Debug.Log(targetObject.name + " ������!");
    }
}
