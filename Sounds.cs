using UnityEngine;
using UnityEngine.Audio;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Sounds
{
    public string name;
    public AudioClip clip;
    [Range(0f,1f)]
    public float volume;
    [HideInInspector]
    public AudioSource source;
    public bool loop;
}
