using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioControl : MonoBehaviour
{
    public AudioSource music1;
    public AudioSource music2;
    public AudioSource music3;
    public AudioSource music4;
    public AudioSource music5;
    public AudioSource music6;

    public static int musicNum;

    public static bool musicIsChanged;

    // Start is called before the first frame update
    void Start()
    {
        musicNum = 0;
        musicIsChanged = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (musicIsChanged == false) return;
        musicIsChanged = false;

        music1.GetComponent<AudioSource>().Stop();
        music2.GetComponent<AudioSource>().Stop();
        music3.GetComponent<AudioSource>().Stop();
        music4.GetComponent<AudioSource>().Stop();
        music5.GetComponent<AudioSource>().Stop();
        music6.GetComponent<AudioSource>().Stop();

        switch (musicNum)
        {
            case 0:
                break;
            case 1:
                //play music
                StartCoroutine(Music1());
                break;
            case 2:
                //play music
                StartCoroutine(Music2());
                break;
            case 3:
                //play music
                StartCoroutine(Music3());
                break;
            case 4:
                //play music
                StartCoroutine(Music4());
                break;
            case 5:
                //play music
                StartCoroutine(Music5());
                break;
            case 6:
                //play music
                StartCoroutine(Music6());
                break;
        }
    }

    IEnumerator Music1()
    {
        yield return null;
        music1.GetComponent<AudioSource>().Play();
    }

    IEnumerator Music2()
    {
        yield return null;
        music2.GetComponent<AudioSource>().Play();
    }

    IEnumerator Music3()
    {
        yield return null;
        music3.GetComponent<AudioSource>().Play();
    }

    IEnumerator Music4()
    {
        yield return null;
        music4.GetComponent<AudioSource>().Play();
    }

    IEnumerator Music5()
    {
        yield return null;
        music5.GetComponent<AudioSource>().Play();
    }

    IEnumerator Music6()
    {
        yield return null;
        music6.GetComponent<AudioSource>().Play();
    }
}