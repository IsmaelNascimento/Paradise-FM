using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseStep : MonoBehaviour
{
    public BaseStep NextStep;

    protected void EndStep()
    {
        StepController.Instance.StartStep(NextStep);
    }
}
