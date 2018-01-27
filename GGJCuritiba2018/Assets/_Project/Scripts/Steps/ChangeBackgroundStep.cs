using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackgroundStep : BaseStep
{
    public Sprite Background;

    private void OnEnable()
    {
        StepController.Instance.ChangeBackground(Background);
        EndStep();
    }
}
