using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public Rigidbody rigid;

    public static bool isPlaying;
    public static bool isSelecting;

    [SerializeField] float mouseSpeed = 8f;
    [SerializeField] float moveSpeed = 10f;

    public float jumpPower;
    
    private float mouseX;
    private bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        jumpPower = 5f;
        isJumping = false;
        isPlaying = false;
        isSelecting = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaying) return;
        if (isSelecting) return;
        Move();
        MouseInput();
        Jump();
    }

    void Move()
    {
        Vector3 move;

        move =
            transform.forward * Input.GetAxis("Vertical") * moveSpeed +
            transform.right * Input.GetAxis("Horizontal") * moveSpeed;

        move.y = rigid.velocity.y;

        rigid.velocity = move;
    }
    
    void MouseInput()
    {
        mouseX += Input.GetAxis("Mouse X") * mouseSpeed;
        this.transform.rotation = Quaternion.Euler(0,mouseX,0);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isJumping == true) return;
            Debug.Log("jump");
            isJumping = true;
            rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
}
