using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OutlineManager : MonoBehaviour
{
    float m_OutlineX;
    float m_OutlineY;

    public static OutlineManager Instance { get; private set; }

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

    void SceneLoaded(Scene _scene, LoadSceneMode _mode)
    {
        // change the font size of all the loaded scene
        ChangeOutline();
    }

    public void ChangeOutlineSizeX(float _size)
    {
        m_OutlineX = _size;
        ChangeOutline();
    }

    public void ChangeOutlineSizeY(float _size)
    {
        m_OutlineY = _size;
        ChangeOutline();
    }

    void ChangeOutline()
    {
        var outlineArr = FindObjectsOfType<Outline>();
        foreach (Outline outline in outlineArr)
        {
            outline.effectDistance = new(m_OutlineX, m_OutlineY);
        }
    }
}
