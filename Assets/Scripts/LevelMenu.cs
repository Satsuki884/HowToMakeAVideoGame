using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public int level;
    public void StartLevel()
    {
        
        Debug.Log(level);
        SceneManager.LoadScene(level + 1);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void BackToLevelMenu()
    {
        SceneManager.LoadScene("LevelMenu");
    }
}
