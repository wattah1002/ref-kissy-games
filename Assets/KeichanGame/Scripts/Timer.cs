using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject title;
    public GameObject retry;
    public float timeLimit = 30;
    public float remainingTime;
    public Text countDownText;

    void awake()
    {
        gameOver.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        remainingTime = timeLimit;
        title.SetActive(false);
        retry.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            countDownText.text = remainingTime.ToString("f0");

        }
        else
        {
            title.SetActive(true);
            retry.SetActive(true);
            gameOver.SetActive(true);
        }
    }
}
