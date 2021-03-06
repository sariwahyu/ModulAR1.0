using System.Collections;
using System.Collections.Generic;
using Vuforia;
using UnityEngine;

public class SetActiveDiagonal4 : MonoBehaviour
{
    [Tooltip("List time change child")]
    public float timeNow = 0.0f;
    public float timeChange0 = 5.0f;
    public float timeChange1 = 10.0f;
    public float timeChange2 = 15.0f;
    public float timeChange3 = 20.0f;

    [Tooltip("Duration time looping for each part")]
    public float timeEnd = 25.0f;

    void Update()
    {
        timeNow += Time.deltaTime;

        if (timeNow > timeChange0 && timeChange0 != 0)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(2).gameObject.SetActive(false);
            transform.GetChild(3).gameObject.SetActive(false);
        }
        if (timeNow > timeChange1 && timeChange1 != 0)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(false);
            transform.GetChild(3).gameObject.SetActive(false);
        }
        if (timeNow > timeChange2 && timeChange2 != 0)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(2).gameObject.SetActive(true);
            transform.GetChild(3).gameObject.SetActive(false);
        }
        if (timeNow > timeChange3 && timeChange3 != 0)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(2).gameObject.SetActive(false);
            transform.GetChild(3).gameObject.SetActive(true);
        }



        if (timeNow > timeEnd)
        {
            if (timeChange0 != 0)
            {
                transform.GetChild(0).gameObject.SetActive(false);
            }
            if (timeChange1 != 0)
            {
                transform.GetChild(1).gameObject.SetActive(false);
            }
            if (timeChange2 != 0)
            {
                transform.GetChild(2).gameObject.SetActive(false);
            }
            if (timeChange3 != 0)
            {
                transform.GetChild(3).gameObject.SetActive(false);
            }
            timeNow = 0.0f;
        }
    }
}