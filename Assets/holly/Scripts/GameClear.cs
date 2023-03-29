using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClear : MonoBehaviour
{
    public GameObject Refunoid;
    public GameObject ClearEffect;
    public GameObject EffectPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Wall")
        {
            Debug.Log("clear!!!");
            Instantiate(ClearEffect.gameObject, EffectPoint.transform.position, Quaternion.identity);
            Refunoid.gameObject.SetActive (false);
        }
    }
}
