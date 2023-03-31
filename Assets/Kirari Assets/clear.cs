using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class clear : MonoBehaviour
{
    [SerializeField] Text nextText;
    private int count;

    void Start()
    {
        count = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            count++;
        }
        if (count == 0)
        {
            nextText.text = "Game Clear";
        }
        if (count == 1)
        {
            nextText.text = "れふ　きっしー";
        }
        else if (count == 2)
        {
            nextText.text = "今まで本当に\nおせわになりました";
        }
        else if (count == 3)
        {
            nextText.text = "二人の活躍を\n願っています";
        }
        else if (count == 4)
        {
            nextText.text = "ありがとう\nございました！";

        }
        else if (count == 5)
        {
            SceneManager.LoadScene("HomeScene");

        }
    }
}
