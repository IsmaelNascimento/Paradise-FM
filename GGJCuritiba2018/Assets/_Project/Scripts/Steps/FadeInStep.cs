using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInStep : BaseStep
{
    public SpriteRenderer[] SpritesToFadeIn;
    public float FadeInTime;

    public void OnEnable()
    {
        for (int spriteIndex = 0; spriteIndex < SpritesToFadeIn.Length; spriteIndex++)
        {
            SpritesToFadeIn[spriteIndex].DOFade(1f, FadeInTime);
        }
        StartCoroutine(WaitAndGo());
    }

    private IEnumerator WaitAndGo()
    {
        yield return new WaitForSeconds(FadeInTime);
        EndStep();
    }
}
