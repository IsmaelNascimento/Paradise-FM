using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundStep : BaseStep
{
    public AudioClip Sound;

    private void OnEnable()
    {
        StepController.Instance.StepAudioSource.clip = Sound;
        StepController.Instance.StepAudioSource.Play();
        EndStep();
    }
}
