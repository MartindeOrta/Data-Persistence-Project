using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;

#endif


public class MenuUIHandler : MonoBehaviour
{
    public Text NombreText;
    public Text BestScoreText;
    // Start is called before the first frame update
    void Start()
    {
        SaveName.instance.LoadNameBestScore();
        SaveName.instance.LoadPointBest();
        BestScoreText.text = $"Best Score: { SaveName.instance.NombrebestText}: {SaveName.instance.bestScore}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void StartGame()
    {
        SceneManager.LoadScene(1);
        SaveName.instance.NombreText = NombreText.text;
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
