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

    [SerializeField] private Text m_TextClock;
    private bool m_IsOpenBook = false;

    public void SetNewHourInClock(string hour)
    {
        m_TextClock.text = hour;
    }

    #region Buttons

    public void OpenBook()
    {
        print("Book open");
    }

    public void ChangeVolumeMusic(Slider slider)
    {
        print("slider volume value:: " + slider.value);
    }

    public void ChangeVolumeFx(Slider slider)
    {
        print("slider fx value:: " + slider.value);
    }

    #endregion
}
