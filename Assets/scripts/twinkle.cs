using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class twinkle : MonoBehaviour
{
    private string text1;
    private string text2;
    private string text3;
    private string text4;
    private string text5;
    private string text6;
    private string text7;
    private string text8;
    private string text9;
    public TMP_Text targetText1;
    public TMP_Text targetText2;
    public TMP_Text targetText3;
    public TMP_Text targetText4;
    public TMP_Text targetText5;
    public TMP_Text targetText6;
    public TMP_Text targetText7;
    public TMP_Text targetText8;
    public TMP_Text targetText9;
    private float delay = 0.125f;

    public int textCnt = 0;

    void Start()
    {
        text1 = targetText1.text.ToString();
        text2 = targetText2.text.ToString();
        text3 = targetText3.text.ToString();
        text4 = targetText4.text.ToString();
        text5 = targetText5.text.ToString();
        text6 = targetText6.text.ToString();
        text7 = targetText7.text.ToString();
        text8 = targetText8.text.ToString();
        text9 = targetText9.text.ToString();
        targetText1.text = " ";
        targetText2.text = " ";
        targetText3.text = " ";
        targetText4.text = " ";
        targetText5.text = " ";
        targetText6.text = " ";
        targetText7.text = " ";
        targetText8.text = " ";
        targetText9.text = " ";

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)){
            StartCoroutine(textPrint1(delay));
            if (Input.GetKeyDown(KeyCode.Space))
            {
                targetText1.gameObject.SetActive(false);
            }
        }
    }

    IEnumerator textPrint1(float d)
    {
        int count = 0;

        while (count != text1.Length)
        {
            if (count < text1.Length)
            {
                targetText1.text += text1[count].ToString();
                count++;
            }

            yield return new WaitForSeconds(delay);
        }
    }

    IEnumerator textPrint2(float d)
    {
        int count = 0;

        while (count != text2.Length)
        {
            if (count < text2.Length)
            {
                targetText2.text += text2[count].ToString();
                count++;
            }

            yield return new WaitForSeconds(delay);
        }
    }
}