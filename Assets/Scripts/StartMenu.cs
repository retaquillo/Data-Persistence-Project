using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using TMPro;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public TMP_InputField inputField;
    public Text bestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        bestScoreText.text = "Best Score: " + DataManager.Instance.BestScoreName + " : " + DataManager.Instance.BestScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadName()
    {
        string name;
        name = inputField.text;
        Debug.Log("ReadName: " + name);
        DataManager.Instance.PlayerName = name;
    }

    public void StartMain()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitMenu()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
