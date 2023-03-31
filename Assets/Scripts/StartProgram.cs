using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartProgram : MonoBehaviour
{
    public GameObject SayStart;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SayStart2Program>();
        SayStart.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
