using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuHandlerUI : MonoBehaviour
{
    public TMP_InputField user_inputField;
    public TextMeshProUGUI user_name;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            setName();
        }
    }

    public void setName()
    {
        user_name.text  = user_inputField.text ;
        SaveManager.Instance.userName = user_name.text;
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
