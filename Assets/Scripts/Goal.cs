using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public GameObject vanilla;
    public GameObject cocoa;
    void Start(){
        vanilla.SetActive(false);
        cocoa.SetActive(false);
    }
    public void Vanilla(){
        vanilla.SetActive(true);
    }
    public void Cocoa(){
        cocoa.SetActive(true);
    }
}