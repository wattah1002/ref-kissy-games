using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZzEffectDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Zz");
        Destroy(this.gameObject,1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
