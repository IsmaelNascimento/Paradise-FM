using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackgroundStep : BaseStep
{
    public Sprite Background;

    private void OnEnable()
    {
        StartCoroutine(ChangeBackground());
    }

    private IEnumerator ChangeBackground()
    {
        StepController.Instance.ChangeBackground(Background);
        yield return new WaitForSeconds(StepController.Instance.BackgroundSwitchTime);
        EndStep();
    }
}
