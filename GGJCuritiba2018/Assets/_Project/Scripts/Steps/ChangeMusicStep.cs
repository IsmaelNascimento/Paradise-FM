using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMusicStep : BaseStep
{
    public AudioSource Source;
    public AudioClip Clip;

    private void OnEnable()
    {
        Source.clip = Clip;
        Source.DOFade(0f, 1f).OnComplete(() =>
        {
            Source.clip = Clip;
            Source.Play();
            Source.DOFade(1f, 1f).OnComplete(() =>
            {
                EndStep();
            }); ;
        });

    }
}
