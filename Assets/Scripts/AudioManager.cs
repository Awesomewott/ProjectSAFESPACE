using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource[] audioSources;
    static AudioManager instance = null;

    private void Awake()
    {
        instance = this;
    }

    public static AudioManager Instance
    {
        get
        {
            return instance;
        }
    }

    // Prone To ArrayOutOfBounds Exception
    public void PlayAudioByIndex(int index)
    {
        audioSources[index].Play();
    }

    public void PlayAudioByName(string name)
    {
        bool found = false;

        foreach (AudioSource audio in audioSources)
        {
            if (audio.name.Equals(name))
            {
                audio.Play();
                found = true;
                break;
            }
        }

        if (!found) Debug.LogError($"{name} Audio Not Found");
    }
}
