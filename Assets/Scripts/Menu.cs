using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Menu : MonoBehaviour
{

    public void GoToLevelChoice(){
        SceneManager.LoadScene(1);
    }
    public void GoToLevelWithObstacle(){
        SceneManager.LoadScene(3);
    }
    public void GoToLevelWithoutObstacle(){
        SceneManager.LoadScene(2);
    }
    public void QuitGame(){
        Application.Quit();
        EditorApplication.isPlaying = false;
    }
}