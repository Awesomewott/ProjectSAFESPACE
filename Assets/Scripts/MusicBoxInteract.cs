using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBoxInteract : Interactable
{
    public AudioSource[] audioSources;
    public bool isPlaying = false;
    static MusicBoxInteract instance = null;
    int index = 0;

     private void Start()
    {
        UpdateAudioPlayer();
    }

    void UpdateAudioPlayer()
    {
        //audioSources[index].enabled = isPlaying;

        //set the current audio playing to false


        //light.enabled = isOn;
    }

    public override string GetDescription()
    {
        if (audioSources[index].enabled) return "Press <color=purple>[A]</color> to turn <color=red>off</color> the Music Player. Press X or Y to Change Music.";
        return "Press <color=purple>[A]</color> to turn <color=green>on</color> the Music Player.";
    }

    public override void Interact()
    {
        isPlaying = !isPlaying;
        if(isPlaying == true)
        {
            audioSources[index].enabled = true;
            audioSources[index].Play();
        }
        else
        {
            audioSources[index].Stop();
            audioSources[index].enabled = false;
        }
        //light.enabled = !light.enabled;
        //UpdateAudioPlayer();
    }

    public void changeSong(int i)
    {

        audioSources[index].enabled = false;
        audioSources[index].Stop();
        //move the index up by one or down by one
        index += i;
        if(index < 0)
        {
            index = audioSources.Length - 1;
        }
        else if (index >= audioSources.Length)
        {
            index = 0;
        }
        audioSources[index].enabled = true;
        audioSources[index].Play();

        //then set current audio playing to true
    }
}
