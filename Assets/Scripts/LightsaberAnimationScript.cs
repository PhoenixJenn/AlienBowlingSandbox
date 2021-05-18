using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsaberAnimationScript : MonoBehaviour
{
    // Start is called before the first frame update
 
 public Animator LightsaberAnimator;
 public AudioSource audioSource;
public AudioClip audioClip;
public void TurnLightsaberOn(){
LightsaberAnimator.SetTrigger("TurnOn"); 
LightsaberAnimator.ResetTrigger("TurnOff");
Debug.Log("Turning Lightsaber On"); 
// audioSource.PlayBeamOn(audioClip);
audioSource.PlayOneShot(audioClip);
}
public void TurnLightsaberOff(){
    LightsaberAnimator.SetTrigger("TurnOff");
    LightsaberAnimator.ResetTrigger("TurnOn");
    // audioSource.PlayBeamOn(audioClip);
}

}
