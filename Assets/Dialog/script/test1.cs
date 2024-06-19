using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test1 : MonoBehaviour
{
    public float time =100f;
    public float target;
    public bool test_1;

    public static bool start;
    public static bool second;

    void Start()
    {
        start = false;
        second = false;
    }

    void Update()
    {
        if (playerMove.isPlaying)
            start = true;

        if (start && second == false)
        {
            start = false;
            StartCoroutine("timer");

        }
        else if(start && second)
        {
            start = false;
            StartCoroutine("timer1");
        }
    }

    
    IEnumerator timer()
    {
        yield return new WaitUntil(() => {

            if (time <= 0)
            {
                return true;
            }
            else
            {

                if (time <= target)
                {
                    if (dialog.instance.dialog_read(0) && !dialog.instance.running)
                    {
                        IEnumerator dialog_co = dialog.instance.dialog_system_start(0);
                        StartCoroutine(dialog_co);
                        
                        if (dialog.instance.dialog_read(0))
                        {
                            return false;
                        }

                    }else if (!dialog.instance.dialog_read(0) && !dialog.instance.running)
                    {
                        time -= Time.deltaTime;
                        
                    }
                }
                else
                {
                    time -= Time.deltaTime;
                    
                }
                
                return false;
            }
        });
    }

    IEnumerator timer1()
    {
        yield return new WaitUntil(() => {
            time = 100;
            if (time <= 0)
            {
                return true;

            }
            else
            {
                
                if (time <= target)
                {
                    if (dialog.instance.dialog_read(1) && !dialog.instance.running)
                    {
                        IEnumerator dialog_co = dialog.instance.dialog_system_start(1);
                        StartCoroutine(dialog_co);

                        if (dialog.instance.dialog_read(1))
                        {
                            return false;
                        }

                    }
                    else if (!dialog.instance.dialog_read(1) && !dialog.instance.running)
                    {
                        time -= Time.deltaTime;

                    }
                }
                else
                {
                    time -= Time.deltaTime;

                }

                return false;
            }
        });
    }

    /*
    IEnumerator timer_action()
    {
        yield return new WaitUntil(() => {
            if (time <= 0)
            {
                return true;
            }
            else
            {

                if (time <= target)
                {
                    if (dialog.instance.dialog_read(0) && !dialog.instance.running)
                    {
                        IEnumerator dialog_co = dialog.instance.dialog_system_start(0);
                        StartCoroutine(dialog_co);

                        if (dialog.instance.dialog_read(0))
                        {
                            return false;
                        }

                    }
                    else if (!dialog.instance.dialog_read(0) && !dialog.instance.running)
                    {
                        time -= Time.deltaTime;
                        time_text.text = time.ToString();
                    }

                }

                return false;
            }
        });
    }*/
}
