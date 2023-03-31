using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateUpDown : MonoBehaviour
{
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(pos.x, pos.y + Mathf.Sin(Time.time) * 1, pos.z);
    }
}
