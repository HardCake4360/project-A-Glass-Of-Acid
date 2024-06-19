using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_rotate : MonoBehaviour
{
    [SerializeField] public float mouseSpeed = 8f; //ȸ���ӵ�
    private float mouseX; //�¿� ȸ������ ���� ����
    private float mouseY; //���Ʒ� ȸ������ ���� ����
    public float minClamp = -50f;
    public float maxClamp = 90f;

    // Start is called before the first frame update
    void Start()
    {
        mouseY = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMove.isPlaying) return;
        if (playerMove.isSelecting) return;

        mouseY += Input.GetAxis("Mouse Y") * mouseSpeed;
        mouseX += Input.GetAxis("Mouse X") * mouseSpeed;

        mouseY = Mathf.Clamp(mouseY, minClamp, maxClamp);
        
        this.transform.localEulerAngles = new Vector3(-mouseY, mouseX, 0);
    }
}
