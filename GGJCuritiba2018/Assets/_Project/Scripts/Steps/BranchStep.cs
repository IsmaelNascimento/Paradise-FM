using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchStep : BaseStep {
    public string Question;
    public Choice[] Choices;

    //private void OnEnable()
    //{
    //    for (int i = 0; i < Choices.Length; i++)
    //    {
    //        Choice choice = Choices[i];
    //        AnswersManager.Instance.SetTextButtonAnswers(i, choice.Label);
    //    }
    //    AnswersManager.Instance.SetTextQuestion(Question);
    //    AnswersManager.Instance.ActivePanelAnswers(Choices.Length);
    //    StepController.Instance.HideText();
    //}

    //private void Update()
    //{
    //    int id = AnswersManager.Instance.GetIDSelected();
    //    if (0 <= id)
    //    {
    //        AnswersManager.Instance.Reset();
    //        StepController.Instance.StartStep(Choices[id].Step);
    //    }
    //}

    private void OnGUI()
    {
        StepController.Instance.HideText();
        GUILayout.Label(Question);
        for (int i = 0; i < Choices.Length; i++)
        {
            Choice choice = Choices[i];
            if (GUILayout.Button(choice.Label))
            {
                StepController.Instance.StartStep(choice.Step);
            }
        }
    }
}
