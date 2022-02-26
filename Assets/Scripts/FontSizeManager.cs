using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class FontSizeManager : MonoBehaviour
{
    public float fontSize = 14;

    public static FontSizeManager Instance { get; private set; }

    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            SceneManager.sceneLoaded += SceneLoaded;
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= SceneLoaded;
    }

    void SceneLoaded(Scene _scene, LoadSceneMode _mode)
    {
        // change the font size of all the loaded scene
        ChangeAllFontSize();
    }

    public void ChangeFontSize(float _size)
    {
        fontSize = _size;
        ChangeAllFontSize();
    }

    void ChangeAllFontSize()
    {
        var arrayOfTextUI = FindObjectsOfType<TextMeshProUGUI>();
        foreach (var textUI in arrayOfTextUI)
        {
            textUI.fontSize = fontSize;
        }
    }
}
