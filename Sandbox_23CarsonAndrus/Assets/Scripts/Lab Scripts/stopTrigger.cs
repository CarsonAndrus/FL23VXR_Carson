using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopTrigger : MonoBehaviour
{
    public AudioSource stopSound;
    //Stops clip when trigger is hit.
    void OnTriggerEnter(Collider other)
    {
        stopSound.Stop();
    }
}
