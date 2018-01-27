using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitStep : BaseStep
{
    public float SecondsToWait;

    private void OnEnable()
    {
        StartCoroutine(WaitAndGo());
    }

    private IEnumerator WaitAndGo()
    {
        yield return new WaitForSeconds(SecondsToWait);
        EndStep();
    }
}
