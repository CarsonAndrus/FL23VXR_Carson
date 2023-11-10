using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Diningroomtransition : MonoBehaviour
{
    public AudioSource audio;
    public AudioMixerSnapshot Diningroom;





    void OnTriggerEnter(Collider other)
    {
        Diningroom.TransitionTo(2);
    }
}
