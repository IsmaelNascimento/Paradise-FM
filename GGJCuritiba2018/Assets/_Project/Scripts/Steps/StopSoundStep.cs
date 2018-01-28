using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSoundStep : BaseStep
{
    public AudioSource source;

    private void OnEnable()
    {
        source.DOFade(0f, 1f).OnComplete(() =>
        {
            EndStep();
        });
    }

}
