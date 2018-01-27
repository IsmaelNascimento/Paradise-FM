using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionStep : BaseStep
{
    public Interaction[] Interactions;
    public GameObject[] ObjectsToEnable;

    private void OnEnable()
    {
        StepController.Instance.HideText();
        for (int objectIndex = 0; objectIndex < ObjectsToEnable.Length; objectIndex++)
        {
            ObjectsToEnable[objectIndex].SetActive(true);
        }
        for (int interactionIndex = 0; interactionIndex < Interactions.Length; interactionIndex++)
        {
            Interactions[interactionIndex].enabled = true;
        }
    }

    private void OnDisable()
    {
        for (int interactionIndex = 0; interactionIndex < Interactions.Length; interactionIndex++)
        {
            Interactions[interactionIndex].enabled = false;
        }
        for (int objectIndex = 0; objectIndex < ObjectsToEnable.Length; objectIndex++)
        {
            ObjectsToEnable[objectIndex].SetActive(false);
        }
    }
}
