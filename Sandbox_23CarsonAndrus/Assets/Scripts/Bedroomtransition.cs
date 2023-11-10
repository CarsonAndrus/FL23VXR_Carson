using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class Bedroomtransition : MonoBehaviour
{
    public AudioSource audio;
    public AudioMixerSnapshot Bedroom;
    

    

    
    void OnTriggerEnter(Collider other)
    {
        Bedroom.TransitionTo(2);
    }

   

}
