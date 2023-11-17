using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class volumeController : MonoBehaviour
{
    public float volume;
    public AudioMixer mixer;

    public void setVolume(float volume)
    {
        mixer.SetFloat("Volume", volume);
    }
}
