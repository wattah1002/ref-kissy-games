using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holly_PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey ("right") || Input.GetKey(KeyCode.D)) {
            transform.Rotate(0,-2,0);
        }
        if (Input.GetKey ("left") || Input.GetKey (KeyCode.A)) {
            transform.Rotate(0,2,0);
        }
    }
}
