using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacterStep : BaseStep
{
    public Sprite Character;

    private void Start()
    {
        StepController.Instance.ChangeCharacter(Character);
        EndStep();
    }
}
