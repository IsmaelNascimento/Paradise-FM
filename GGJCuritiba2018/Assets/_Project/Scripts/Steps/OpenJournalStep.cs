using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenJournalStep : BaseStep
{
    private void OnEnable()
    {
        HudManager.Instance.OpenOrCloseBook();
        EndStep();
    }
}
