using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SleepMeter : MonoBehaviour
{
    public float SleepingBarometer;

    private Slider setSlider;
    public GameObject slider;

    // Start is called before the first frame update
    void Start()
    {
        SleepingBarometer = 50;
        StartCoroutine("Nemukunaru");

        setSlider = slider.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        setSlider.value = SleepingBarometer;
    }
    
    IEnumerator Nemukunaru(){
        yield return new WaitForSeconds(1);
        SleepingBarometer ++;
        Debug.Log(SleepingBarometer);
        if (SleepingBarometer < 0)
        {
            Debug.Log("Clear");
        }
        else if (SleepingBarometer < 100)
        {
            StartCoroutine("Nemukunaru");
        }
        else
        {
            Debug.Log("Over Oyasumi");
        }
    }
}
