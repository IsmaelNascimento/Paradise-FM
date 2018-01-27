using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepController : MonoBehaviour
{
    public BaseStep CurrentStep;
    public SpriteRenderer Background;
    public SpriteRenderer Character;

    private static StepController instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        CurrentStep.gameObject.SetActive(true);
    }

    public static void ChangeBackground(Sprite backgroundSprite)
    {
        instance.Background.sprite = backgroundSprite;
    }

    public static void ChangeCharacter(Sprite characterSprite)
    {
        instance.Character.sprite = characterSprite;
    }

    public static void StartStep(BaseStep nextStep)
    {
        instance.CurrentStep.gameObject.SetActive(false);
        instance.CurrentStep = nextStep;
        if (nextStep)
        {
            instance.CurrentStep.gameObject.SetActive(true);
        }
    }
}
