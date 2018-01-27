using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Interaction : MonoBehaviour {
    public BaseStep NextStep;

    private void OnMouseDown()
    {
        StepController.Instance.StartStep(NextStep);
    }
}
