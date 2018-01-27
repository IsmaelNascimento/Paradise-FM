using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchStep : BaseStep {
    public string Question;
    public Choice[] Choices;

    private void OnGUI()
    {
        GUILayout.Label(Question);
        for (int i = 0; i < Choices.Length; i++)
        {
            Choice choice = Choices[i];
            if (GUILayout.Button(choice.Label))
            {
                StepController.Instance.StartStep(choice.step);
            }
        }
    }
}
