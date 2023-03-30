using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectManager : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip[] SE;

    void Start(){
        audioSource = GetComponent<AudioSource>();
    }
    public void PlaySE(int num){
        audioSource.PlayOneShot(SE[num]);
    }

}
