using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FontChangeComp : MonoBehaviour
{
    public TMP_Dropdown m_FontSizeDropdown;

    public void ChangeFontSize(int index)
    {
        FontSizeManager.Instance.ChangeFontSize(float.Parse(m_FontSizeDropdown.options[index].text));
    }
}
