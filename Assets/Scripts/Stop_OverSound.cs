using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stop_OverSound : MonoBehaviour
{
    GameObject Refunoid;
    // Start is called before the first frame update
    void Start()
    {
        Refunoid = GameObject.Find("refu_noid");
    }

    // Update is called once per frame
    void Update()
    {
        if(!Refunoid.gameObject.activeSelf)
        {
            SceneManager.LoadScene("HollyGameOver");
            Destroy(this.gameObject,2);
        }
    }
}
