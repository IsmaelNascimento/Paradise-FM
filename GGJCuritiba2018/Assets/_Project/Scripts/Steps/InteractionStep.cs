using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionStep : BaseStep
{
    public Interaction[] Interactions;

    private void OnEnable()
    {
        StepController.Instance.HideText();
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
    }
}
