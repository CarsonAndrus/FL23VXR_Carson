using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    

    public AudioSource soundPlayer;
    
    
    
 
    //plays audiosource
    public void playSoundEffect()
    {
        soundPlayer.Play();
    }
    /*
    //stops audiosource
    public void stopSoundEffect()
    {
        soundPlayer.Stop();
    }
    */



}
