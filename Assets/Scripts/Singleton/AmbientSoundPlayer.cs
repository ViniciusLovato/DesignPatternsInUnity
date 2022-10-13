using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientSoundPlayer
{
    private AmbientSoundPlayer instance;
    
    public AmbientSoundPlayer GetInstance()
    {
        return instance ??= new AmbientSoundPlayer();
    }
    
    private AmbientSoundPlayer(){}

    public void FadeNewMusic(AudioClip clip)
    {
        // TODO
    }
}
