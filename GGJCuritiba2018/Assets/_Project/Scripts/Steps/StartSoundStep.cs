using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSoundStep : BaseStep
{
    public AudioSource source;
    public AudioClip clip;

    private void OnEnable()
    {
        source.clip = clip;
        source.volume = 1f;
        source.Play();
        EndStep();
    }
}
