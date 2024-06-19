using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titleImg : MonoBehaviour
{
    public GameObject img1;
    public GameObject img2;
    public GameObject img3;

    int clickCnt;

    // Start is called before the first frame update
    void Start()
    {
        clickCnt = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) clickCnt++;
        if (clickCnt == 3)
        {
            img1.gameObject.SetActive(false);
            img2.gameObject.SetActive(true);
        }
        if (clickCnt == 6)
        {
            img2.gameObject.SetActive(false);
            img3.gameObject.SetActive(true);
        }
        if(clickCnt >= 10)
        {
            //call game scene
            SceneManager.LoadScene("mainScene");
        }
    }
}
