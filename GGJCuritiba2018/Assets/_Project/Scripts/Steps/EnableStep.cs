using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableStep : BaseStep
{
    public GameObject[] ObjectsToEnable;
    public GameObject[] ObjectsToDisable;

    private void OnEnable()
    {
        for (int objectIndex = 0; objectIndex < ObjectsToDisable.Length; objectIndex++)
        {
            ObjectsToDisable[objectIndex].SetActive(false);
        }
        for (int objectIndex = 0; objectIndex < ObjectsToEnable.Length; objectIndex++)
        {
            ObjectsToEnable[objectIndex].SetActive(true);
        }
        EndStep();
    }
}
