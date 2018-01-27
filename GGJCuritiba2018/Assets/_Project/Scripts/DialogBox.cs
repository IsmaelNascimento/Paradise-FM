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

    private bool m_OnInput = false;

    [ContextMenu("SetTextDialogBox")]
    public void SetTextDialogBox(string newText)
    {
        textDialogBox.text = newText;
    }

    [ContextMenu("AnimationInput")]
    public void AnimationInput()
    {
        if(!m_OnInput)
            GetComponent<Animator>().Play("DialogBoxInput");

        m_OnInput = true;
    }

    [ContextMenu("AnimationOutput")]
    public void AnimationOutput()
    {
        GetComponent<Animator>().Play("DialogBoxOutput");
        m_OnInput = false;
    }

    public void ActionButtonDialofgBox(UnityAction action)
    {
        if (action != null)
            m_ButtonDialogBox.onClick.AddListener(action);
    }
}