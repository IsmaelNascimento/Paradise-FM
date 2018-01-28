using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManager : MonoBehaviour
{
    private static HudManager m_Instance;
    public static HudManager Instance
    {
        get
        {
            if (m_Instance == null)
                m_Instance = FindObjectOfType(typeof(HudManager)) as HudManager;

            return m_Instance;
        }
    }

    [Header("Setup HUD")]
    [SerializeField] private Text m_TextClock;
    [Space(15)]
    [Header("Setup Book")]
    [SerializeField] private GameObject m_Book;
    [SerializeField] private Image m_ImageBook;
    [SerializeField] private Sprite[] m_PagesBook;
    [Space(15)]
    [SerializeField] private GameObject m_SymbolFind;

    private bool m_IsOpenBook = false;
    private int m_PageCurrent = 0;
    private bool m_CallSymbolFirst = true;

    public void SetNewHourInClock(string hour)
    {
        m_TextClock.text = hour;
    }

    #region Buttons

    public void OpenOrCloseBook()
    {
        if (!m_CallSymbolFirst)
        {
            m_SymbolFind.SetActive(false);
        }

        if (m_IsOpenBook)
            m_Book.SetActive(false);
        else
            m_Book.SetActive(true);

        m_IsOpenBook = !m_IsOpenBook;
    }

    public void ChangeVolumeMusic(Slider slider)
    {
        print("slider volume value:: " + slider.value);
    }

    public void ChangeVolumeFx(Slider slider)
    {
        print("slider fx value:: " + slider.value);
    }

    public void NextPage()
    {
        if (m_SymbolFind.activeInHierarchy)
        {
            m_SymbolFind.SetActive(false);
            m_CallSymbolFirst = false;
            print("Call any action");
            // Chama alguma ação aqui
        }

        m_PageCurrent++;

        if (m_PageCurrent < m_PagesBook.Length)
        {
            m_ImageBook.sprite = m_PagesBook[m_PageCurrent];

            //if (m_PageCurrent == 3)
            //    m_SymbolFind.SetActive(true);
        }
        else
        {
            m_Book.SetActive(false);
            m_ImageBook.sprite = m_PagesBook[0];
            m_PageCurrent = 0;
            m_IsOpenBook = false;
        }
    }

    #endregion
}