using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    public void StartGame()
    {
        Debug.Log("Start game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
