using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerSoundEffect : MonoBehaviour
{
 
 public AudioSource playSound;
    //plays clip when trigger is hit.
    void OnTriggerEnter(Collider other)
    {
        playSound.Play();
    }

}
