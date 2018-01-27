using UnityEngine;
using DG.Tweening;

public class StepController : MonoBehaviour
{
    [SerializeField] private BaseStep CurrentStep;
    [SerializeField] private DialogBox DialogBox;
    [SerializeField] private SpriteRenderer Front;
    [SerializeField] private SpriteRenderer Back;
    public float TextSpeed = 1f;
    private static StepController instance;
    public static StepController Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        if (null != instance)
        {
            Debug.LogError("Multiple StepControllers");
        }
        instance = this;
    }

    private void Start()
    {
        CurrentStep.gameObject.SetActive(true);
    }

    public void ChangeBackground(Sprite backgroundSprite)
    {
        Back.sprite = backgroundSprite;

        Front.DOFade(0f, 1f).OnComplete(() => 
        {
            var aux = Front.sprite;
            Front.sprite = Back.sprite;
            Back.sprite = aux;

            Front.color = Color.white;
        });
    }

    public void ShowText(string text)
    {
        DialogBox.AnimationInput();
        DialogBox.SetTextDialogBox(text);
    }

    public void HideText()
    {
        DialogBox.AnimationOutput();
    }

    public void SkipText()
    {
        (CurrentStep as TextStep).Skip();
    }

    //private IEnumerator TextCoroutine(string[] text)
    //{
    //    for (int textIndex = 0; textIndex < text.Length; textIndex++)
    //    {
    //        string sentence = text[textIndex];
    //        int charIndex;
    //        for (charIndex = 0; !isSentenceComplete && charIndex < sentence.Length; charIndex++)
    //        {
    //            yield return new WaitForSeconds(1f/TextSpeed);
    //            DialogBox.SetTextDialogBox(sentence.Substring(0, charIndex));
    //        }
    //        charIndex = sentence.Length;
    //        DialogBox.SetTextDialogBox(sentence.Substring(0, charIndex));
    //        isSentenceComplete = true;
    //        while (isSentenceComplete)
    //        {
    //            yield return null;
    //        }
    //    }

    //    instance.DialogBox.AnimationOutput();
    //}

    public void StartStep(BaseStep nextStep)
    {
        CurrentStep.gameObject.SetActive(false);
        CurrentStep = nextStep;
        if (nextStep)
        {
            CurrentStep.gameObject.SetActive(true);
        }
    }
}
