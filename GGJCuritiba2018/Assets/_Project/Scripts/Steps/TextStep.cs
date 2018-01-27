using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextStep : BaseStep {
    public string[] Text;
    private int textIndex;
    private int charIndex;
    private bool isWaiting;

    private IEnumerator Start()
    {
        for (textIndex = 0; textIndex < Text.Length; textIndex++)
        {
            string sentence = Text[textIndex];
            for (charIndex = 0; charIndex < sentence.Length; charIndex++)
            {
                yield return new WaitForSeconds(0.02f);
            }
            isWaiting = true;
            while (isWaiting)
            {
                yield return null;
            }
        }
        EndStep();
    }

    private void OnGUI()
    {
        GUILayout.Label(Text[textIndex].Substring(0, charIndex));
        if (isWaiting)
        {
            isWaiting = !GUILayout.Button("Next");
        }
    }
}
