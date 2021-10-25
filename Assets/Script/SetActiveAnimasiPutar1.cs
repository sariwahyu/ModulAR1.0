using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveAnimasiPutar1 : MonoBehaviour
{
    [Tooltip("List time change child")]
    public float timeNow = 0.0f;
    public float timeChange0 = 1.0f;
    public float timeChange1 = 8.0f;
    public float timeChange2 = 13.0f;

    [Tooltip("Duration time looping for each part")]
    public float timeEnd = 18.0f;

    void Update()
    {
        timeNow += Time.deltaTime;

        if (timeNow > timeChange0 && timeChange0 != 0)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        if (timeNow > timeChange1 && timeChange1 != 0)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
        }
        if (timeNow > timeChange2 && timeChange2 != 0)
        {
            transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(2).gameObject.SetActive(true);
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
            timeNow = 0.0f;
        }
    }
}
