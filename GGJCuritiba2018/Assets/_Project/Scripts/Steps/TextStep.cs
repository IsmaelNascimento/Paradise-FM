using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class TextStep : BaseStep
{
    public string[] Text;
    [Space(15)]
    public AudioClip[] songs;
    private int textIndex;
    private int charIndex;
    private bool isSentenceComplete = false;

    private void Start()
    {
        if (!GetComponent<AudioSource>())
        {
            gameObject.AddComponent<AudioSource>();
            GetComponent<AudioSource>().playOnAwake = false;
        }
    }

    private void OnEnable()
    {
        StartCoroutine(ShowText());
    }

    private IEnumerator ShowText()
    {
        for (textIndex = 0; textIndex < Text.Length; textIndex++)
        {
            var sentence = Text[textIndex];

            if(textIndex < songs.Length)
            {
                GetComponent<AudioSource>().clip = songs[textIndex];
                GetComponent<AudioSource>().Play();
            }

            for (charIndex = 0; !isSentenceComplete && charIndex < sentence.Length; charIndex++)
            {
                yield return new WaitForSeconds(1f / StepController.Instance.TextSpeed);

                if ('<' == sentence[charIndex])
                {
                    charIndex = sentence.IndexOf('>', charIndex) + 1;
                }

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
        if(isSentenceComplete)
            GetComponent<AudioSource>().Stop();

        isSentenceComplete = !isSentenceComplete;
    }
}
