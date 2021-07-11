using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{

    [SerializeField] private InputField playerName;
    [SerializeField] private TextMeshProUGUI bestScore;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.LoadBestScore();
        bestScore.text = "Best Score: " + GameManager.Instance.bestPlayerName + " - " + GameManager.Instance.bestScore;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        GameManager.Instance.playerName = playerName.text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}
