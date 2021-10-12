using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public bool s_LanguageSceneLoaded;
    public bool q_SceneLoaded;
    public bool q_FormatSceneLoaded;
    public bool m_SceneLoaded;

    void Start()
    {
        s_LanguageSceneLoaded = false;
        q_SceneLoaded = false;
        q_FormatSceneLoaded = false;
        m_SceneLoaded = false;
    }

    public void SelectLanguageToLoad()
    {
        SceneManager.LoadScene ("SelectLanguage", LoadSceneMode.Additive);
        s_LanguageSceneLoaded = true;
    }

   
    public void QuizToLoad() 
    {
        if (s_LanguageSceneLoaded == true)
        {
            SceneManager.UnloadScene ("SelectLanguage");
            SceneManager.LoadScene ("Quiz", LoadSceneMode.Additive);
            q_SceneLoaded = true;
        }
        s_LanguageSceneLoaded = false;
    } 

    public void QuizFormatToLoad() 
    {
        if (q_SceneLoaded == true)
        {
            SceneManager.UnloadScene ("Quiz");
            SceneManager.LoadScene ("QuizFormat", LoadSceneMode.Additive);
            q_FormatSceneLoaded = true;
        }
        q_SceneLoaded = false;
    } 

    public void MainToLoad() 
    {
        if (q_FormatSceneLoaded == true)
        {
            SceneManager.UnloadScene ("QuizFormat");
        }  
        q_FormatSceneLoaded = false;
    } 
}