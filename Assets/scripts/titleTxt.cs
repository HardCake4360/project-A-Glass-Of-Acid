using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleTxt : MonoBehaviour
{
    public GameObject txt1;
    public GameObject txt2;
    public GameObject txt3;
    public GameObject txt4;
    public GameObject txt5;
    public GameObject txt6;
    public GameObject txt7;
    public GameObject txt8;
    public GameObject txt9;
    public GameObject txt10;

    int clickCnt;

    // Start is called before the first frame update
    void Start()
    {
        clickCnt = 0;
        txt1.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) clickCnt++;
        if (clickCnt == 1)
        {
            txt1.gameObject.SetActive(false);
            txt2.gameObject.SetActive(true);
        }
        if (clickCnt == 2)
        {
            txt2.gameObject.SetActive(false);
            txt3.gameObject.SetActive(true);
        }
        if (clickCnt == 3)
        {
            txt3.gameObject.SetActive(false);
            txt4.gameObject.SetActive(true);
        }
        if (clickCnt == 4)
        {
            txt4.gameObject.SetActive(false);
            txt5.gameObject.SetActive(true);
        }
        if (clickCnt == 5)
        {
            txt5.gameObject.SetActive(false);
            txt6.gameObject.SetActive(true);
        }
        if (clickCnt == 6)
        {
            txt6.gameObject.SetActive(false);
            txt7.gameObject.SetActive(true);
        }
        if (clickCnt == 7)
        {
            txt7.gameObject.SetActive(false);
            txt8.gameObject.SetActive(true);
        }
        if (clickCnt == 8)
        {
            txt8.gameObject.SetActive(false);
            txt9.gameObject.SetActive(true);
        }
        if (clickCnt == 9)
        {
            txt9.gameObject.SetActive(false);
            txt10.gameObject.SetActive(true);
        }
    }
}
