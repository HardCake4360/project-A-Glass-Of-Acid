using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_rotate : MonoBehaviour
{
    [SerializeField] public float mouseSpeed = 8f; //회전속도
    private float mouseX; //좌우 회전값을 담을 변수
    private float mouseY; //위아래 회전값을 담을 변수
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
