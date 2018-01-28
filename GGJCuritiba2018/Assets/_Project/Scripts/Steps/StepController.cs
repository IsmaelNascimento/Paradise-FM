using UnityEngine;
using DG.Tweening;

public class StepController : MonoBehaviour
{
    [SerializeField] private BaseStep CurrentStep;
    [SerializeField] private DialogBox DialogBox;
    [SerializeField] private SpriteRenderer Front;
    [SerializeField] private SpriteRenderer Back;
    public float TextSpeed = 1f;
    public float BackgroundSwitchTime = 0.3f;
    private static StepController instance;
    public static StepController Instance
    {
        get
        {
            return instance;
        }
    }
    public AudioSource StepAudioSource
    {
        get; private set;
    }

    private void Awake()
    {
        if (null != instance)
        {
            Debug.LogError("Multiple StepControllers");
        }
        instance = this;
        StepAudioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        CurrentStep.gameObject.SetActive(true);
    }

    public void ChangeBackground(Sprite backgroundSprite)
    {
        Back.sprite = backgroundSprite;

        Front.DOFade(0f, BackgroundSwitchTime).OnComplete(() => 
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
