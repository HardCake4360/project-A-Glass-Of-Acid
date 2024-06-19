using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chairInteract : MonoBehaviour
{
    public GameObject player;
    public GameObject camera;
    public GameObject subCamera;
    public Vector3 targetPos;
    public Vector3 originPos;
    public float speed;

    public Animator anim;

    bool eKeyDown;

    int cnt;

    void Start()
    {
        speed = 10f;
        targetPos = subCamera.transform.position;
        cnt = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            eKeyDown = true;
        }
        else
        {
            cnt++;
            if (cnt == 10)
            {
                cnt = 0;
                eKeyDown = false;
            }
            
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && eKeyDown)
        {
            eKeyDown = false;
            
            playerMove.isPlaying = true;
            anim.SetTrigger("interact");
            Debug.Log("»£√‚µ ");
        }
    }

    bool switchBool(bool boolean)
    {
        return !boolean;
    }
}
