using UnityEngine;
using UnityEngine.UI;

public class AnswersManager : MonoBehaviour
{
    private static AnswersManager m_Instance;
    public static AnswersManager Instance
    {
        get
        {
            if (m_Instance == null)
                m_Instance = FindObjectOfType(typeof(AnswersManager)) as AnswersManager;

            return m_Instance;
        }
    }

    [SerializeField] private GameObject[] m_Buttons;

    private void Start()
    {
        for (int i = 0; i < m_Buttons.Length; i++)
            m_Buttons[i].SetActive(false);
    }

    public void ActivePanelAnswers(int countAnswers)
    {
        for (int i = 0; i < countAnswers; i++)
            m_Buttons[i].SetActive(true);
    }

    public void OnButtonReturnIDClicked(int id)
    {
        GetIDSelected(id);
    }

    public int GetIDSelected(int id)
    {
        return id;
    }

    public void SetTextButtonAnswers(int idButton, string textAnswers)
    {
        switch (idButton)
        {
            case 0:
                m_Buttons[0].GetComponentInChildren<Text>().text = textAnswers;
                break;
            case 1:
                m_Buttons[1].GetComponentInChildren<Text>().text = textAnswers;
                break;
            case 2:
                m_Buttons[2].GetComponentInChildren<Text>().text = textAnswers;
                break;
        }
    }

    #region Tests com ContextMenu

    [ContextMenu("TestSetTextButtonAnswers")]
    public void TestSetTextButtonAnswers()
    {
        SetTextButtonAnswers(1, "Minha resposta em ingles");
    }

    [ContextMenu("TestActivePanelAnswers")]
    public void TestActivePanelAnswers()
    {
        ActivePanelAnswers(3);
    }

    #endregion
}