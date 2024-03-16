using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
public AudioSource coinAudioSource,crackAudioSource,refuelAudioSource,engineAudioSource,backgroundAudioSource;

    /* public void PlaySoundCoin(){
        PlaySound(coinAudioSource);
    } */
    public void PlaySoundCrack(){
        PlaySound(crackAudioSource);
    }
    public void PlaySoundRefuel(){
        PlaySound(refuelAudioSource);
    }
    public void PlaySoundEngine(){
        PlaySound(engineAudioSource);
    }      
    public void PlaySound(AudioSource audio){
        audio.Play();
    }

}
