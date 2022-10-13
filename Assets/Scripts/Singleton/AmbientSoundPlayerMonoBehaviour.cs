using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientSoundPlayerMonoBehaviour : MonoBehaviour
{
    private static AmbientSoundPlayerMonoBehaviour instance;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        
    }

    public void FadeNewMusic(AudioClip clip)
    {
        // TODO
    }
}
