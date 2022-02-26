using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public void LoadScene(string _name)
    { 
        SceneManager.LoadScene(_name, LoadSceneMode.Additive);
    }

    public void UnloadScene(string _name)
    {
        SceneManager.UnloadSceneAsync(_name);
    }
}
