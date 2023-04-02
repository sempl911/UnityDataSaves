using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuHandlerUI : MonoBehaviour
{
    public TMP_InputField playerName;

    void Start()
    {
        
    }

    void Update()
    {
        TakeName();
    }
    public void TakeName()
    {
        Debug.Log(playerName.text);
    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
# if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
