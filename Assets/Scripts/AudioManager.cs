using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : SingletonBase<AudioManager>
{
    public AudioSource AudioSourceUI;
    public AudioSource SoundBackground;
    public AudioSource AudioWin,AudioLose;

    [Range(0,1)] public float VolumeUI,VolumeBackground, VolumeWin,VolumeLose;

    private void Start()
    {
        SoundBackground.volume = VolumeBackground;
        SoundBackground.Play();
    }
    public void PLayAudioUI()
    {
        AudioSourceUI.volume = VolumeUI;
        AudioSourceUI.Play();
    }
    public void PlayAudioWin()
    {
        AudioWin.volume = VolumeWin;
        AudioWin.Play();
    }
    public void PlayAudioLose()
    {
        AudioLose.volume = VolumeLose;
        AudioLose.Play();
    }
}
