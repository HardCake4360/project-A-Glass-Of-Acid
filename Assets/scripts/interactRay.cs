using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactRay : MonoBehaviour
{
    [SerializeField] private float targetDistance = 10f; // 감지 거리
    [SerializeField] private float rotationSpeed = 100f; // 시점 회전 속도
    public GameObject camera; // 카메라 오브젝트

    private void Update()
    {
        RaycastHit hit;

        // Raycast 발사
        Vector3 rayDirection = camera.transform.forward; // 카메라 방향 사용

        Debug.DrawRay(camera.transform.position, rayDirection * targetDistance, Color.green);

        if (Physics.Raycast(camera.transform.position, rayDirection, out hit, targetDistance))
        {
            // 오브젝트 감지
            if (hit.collider.tag == "Target") // 감지 태그 설정
            {
                // 특정 메서드 호출
                CallMethod(hit.collider.gameObject, rayDirection);
            }
        }
    }

    private void CallMethod(GameObject targetObject,Vector3 rayDirection)
    {
        // 여기에 특정 메서드 로직 작성 (예: 상호 작용 UI 활성화, 정보 표시 등)
        Debug.Log(targetObject.name + " 감지됨!");
    }
}
