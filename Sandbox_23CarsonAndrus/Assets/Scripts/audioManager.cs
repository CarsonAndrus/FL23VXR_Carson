using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    

    public AudioSource soundPlayer;
    public AudioClip clip;
    
    
 
    //plays audiosource
    public void playSoundEffect()
    {
        soundPlayer.Play();
    }
   
    
    
    
    //plays audiosource with a scaled volume of 5.0f
    public void playSoundEffectOneShot()
    {
        soundPlayer.PlayOneShot(clip, 5.0f);
    }


    //stops audiosource
    public void stopSoundEffect()
    {
        soundPlayer.Stop();
    }







}
