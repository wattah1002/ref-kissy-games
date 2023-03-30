using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class KeichanTimer : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject gameOver;
    public GameObject title;
    public GameObject retry;
    public GameObject score;
    public GameObject result;
    public float timeLimit = 30;
    public float remainingTime;
    public Text countDownText;
    public ResultText resultText;

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
        if (remainingTime < 5)
        {
            audioSource.pitch = 1.25f;
        }
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            countDownText.text = remainingTime.ToString("f0");

        }
        else
        {
            audioSource.Stop();
            title.SetActive(true);
            retry.SetActive(true);
            gameOver.SetActive(true);
            score.SetActive(false);
            resultText.GameOver(score.GetComponent<CountScore>().score);
        }
    }
}
