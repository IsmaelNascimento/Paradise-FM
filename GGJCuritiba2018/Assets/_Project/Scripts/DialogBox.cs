using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class DialogBox : MonoBehaviour
{
    private static DialogBox m_Instance;
    public static DialogBox Instance
    {
        get
        {
            if (m_Instance == null)
                m_Instance = FindObjectOfType(typeof(DialogBox)) as DialogBox;

            return m_Instance;
        }
    }

    [SerializeField] private TextMeshProUGUI textDialogBox;
    [SerializeField] private Button m_ButtonDialogBox;

    [ContextMenu("SetTextDialogBox")]
    public void SetTextDialogBox(string newText)
    {
        textDialogBox.text = newText;
    }

    [ContextMenu("AnimationInput")]
    public void AnimationInput()
    {
        GetComponent<Animator>().Play("DialogBoxInput");
    }

    [ContextMenu("AnimationOutput")]
    public void AnimationOutput()
    {
        GetComponent<Animator>().Play("DialogBoxOutput");
    }

    public void ActionButtonDialofgBox(UnityAction action)
    {
        if (action != null)
            m_ButtonDialogBox.onClick.AddListener(action);
    }
}