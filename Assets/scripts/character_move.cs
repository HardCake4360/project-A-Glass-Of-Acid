using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_move : MonoBehaviour
{
    public float movePower = 50f;
    public float jumpPower = 50f;

    Rigidbody2D rigid;
    Animator animator;

    Vector3 movement;
    bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;
        }

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            animator.SetInteger("Dir_horizontal", -1);
            animator.SetBool("isMoving", true);
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            animator.SetInteger("Dir_horizontal", 1);
            animator.SetBool("isMoving", true);
        }
        else if (Input.GetAxisRaw("Horizontal") == 0)
        {
            animator.SetInteger("Dir_horizontal", 0);
            animator.SetBool("isMoving", false);
        }

        if (rigid.velocity.y < 0)
        {
            animator.SetInteger("Dir_vertical", -1);
        }
        else if (rigid.velocity.y == 0)
        {
            animator.SetInteger("Dir_vertical", 0);
        }
    }

    void FixedUpdate()
    {
        Move();
        Jump();
    }

    void Move()
    {
        Vector3 moveVelocity = Vector3.zero;

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            moveVelocity = Vector3.left;
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            moveVelocity = Vector3.right;
        }
        transform.position += moveVelocity * movePower * Time.deltaTime;
    }

    void Jump()
    {
        if (isJumping == false) return;
        animator.SetInteger("Dir_vertical", 1);
        rigid.velocity = Vector2.zero;

        Vector2 jumpVelocity = new Vector2(0, jumpPower);
        rigid.AddForce(jumpVelocity, ForceMode2D.Impulse);

        isJumping = false;
    }
}
