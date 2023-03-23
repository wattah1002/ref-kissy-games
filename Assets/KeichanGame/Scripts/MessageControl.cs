using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageControl : MonoBehaviour
{
    int targetTime = 1;
    float elapsedTime = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= targetTime)
        {
            gameObject.SetActive(false);
        }
    }
}
