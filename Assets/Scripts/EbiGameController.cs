using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EbiGameController : MonoBehaviour
{
    public int scene = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (scene == 0 & Input.anyKey)
        {
            scene = 1;
        }
    }
}
