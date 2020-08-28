using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    public AudioMixer master;
    public void adjustVolume(float volume)
    {
        master.SetFloat("VolumeControl", volume);
    }
}
