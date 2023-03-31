using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EbiHPController : MonoBehaviour
{
    public int hp = 5;
    public Text hpText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hpText.text = hp.ToString();
    }
}
