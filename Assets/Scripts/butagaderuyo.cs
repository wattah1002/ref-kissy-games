using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butagaderuyo : MonoBehaviour
{
    float elapsedTime;
   public float buta1, buta2, buta3, buta4;
   public GameObject buta;
  bool butaDetaka1 = false, butaDetaka2 = false, butaDetaka3 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        elapsedTime += Time.deltaTime;
        if(elapsedTime >= buta1 && !butaDetaka1){
            Instantiate(buta, transform.position, Quaternion.identity, transform);
            butaDetaka1 = true;}
        else if(elapsedTime >= buta2 && !butaDetaka2){
            Instantiate(buta, transform.position, Quaternion.identity, transform);
            butaDetaka2 = true;}
        else if(elapsedTime >= buta3 && !butaDetaka3){
            Instantiate(buta, transform.position, Quaternion.identity, transform);
            butaDetaka3 = true;}
        else if(elapsedTime >= buta4){
            Instantiate(buta, transform.position, Quaternion.identity, transform);
            elapsedTime = 0;
            butaDetaka1 = false;
            butaDetaka2 = false;
            butaDetaka3 = false;}
    }
}
