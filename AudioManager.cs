using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    public Sounds[] sound;
    // Start is called before the first frame update
    void Awake()
    {
        foreach (Sounds s in sound)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.loop = s.loop;
        }
    }

    void Start(){
        Play("Theme");
    }

    public void Play(string name){
        
            Sounds s = Array.Find(sound, sound => sound.name == name);
        if(s==null){
            return;
        }
        s.source.Play();
        
        // Sounds s = Array.Find(sound, sound => sound.name == name);
        // if(s==null){
        //     return;
        // }
        // s.source.Play();
    }
}
