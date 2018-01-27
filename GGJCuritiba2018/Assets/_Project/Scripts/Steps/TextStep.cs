using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextStep : BaseStep {
    public string[] Text;
    private int textIndex;
    private int charIndex;
    private bool isSentenceComplete = false;

    private void OnEnable()
    {
        StartCoroutine(ShowText());
    }

    private IEnumerator ShowText()
    {
        for (textIndex = 0; textIndex < Text.Length; textIndex++)
        {
            string sentence = Text[textIndex];
            for (charIndex = 0; !isSentenceComplete && charIndex < sentence.Length; charIndex++)
            {
                yield return new WaitForSeconds(1f / StepController.Instance.TextSpeed);
                StepController.Instance.ShowText(sentence.Substring(0, charIndex));
            }
            charIndex = sentence.Length;
            StepController.Instance.ShowText(sentence.Substring(0, charIndex));
            isSentenceComplete = true;
            while (isSentenceComplete)
            {
                yield return null;
            }
        }
        EndStep();
    }

    public void Skip()
    {
        isSentenceComplete = !isSentenceComplete;
    }
}
