using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeStep : BaseStep
{
    public SpriteRenderer[] SpritesToFade;
    public float FadeTo;
    public float FadeTime;

    public void OnEnable()
    {
        for (int spriteIndex = 0; spriteIndex < SpritesToFade.Length; spriteIndex++)
        {
            SpritesToFade[spriteIndex].DOFade(FadeTo, FadeTime);
        }
        StartCoroutine(WaitAndGo());
    }

    private IEnumerator WaitAndGo()
    {
        yield return new WaitForSeconds(FadeTime);
        EndStep();
    }
}