using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jukeInteract : MonoBehaviour
{
    public Animator anim;
    public GameObject panel;

    bool eKeyDown;
    int cnt;

    void Start()
    {
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

        if(playerMove.isSelecting == true)
        {
            panel.gameObject.SetActive(true);
        }
        else if(playerMove.isSelecting == false)
        {
            panel.gameObject.SetActive(false);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && eKeyDown)
        {
            eKeyDown = false;
            panel.gameObject.SetActive(true);
            playerMove.isSelecting = switchBool(playerMove.isSelecting);
            anim.SetTrigger("juke");
            Debug.Log("»£√‚µ ");
        }
    }

    bool switchBool(bool boolean)
    {
        return !boolean;
    }
    
}
