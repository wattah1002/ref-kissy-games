using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeLimit = 30;
    public float remainingTime;
    public Text countDownText;
    // Start is called before the first frame update
    void Start()
    {
        remainingTime = timeLimit;
    }

    // Update is called once per frame
    void Update()
    {
        remainingTime -= Time.deltaTime;
        countDownText.text = remainingTime.ToString("f0");
    }
}
