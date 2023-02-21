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
    public void AdminMenu(){
        SceneManager.LoadScene(2);
    }
    public void StraightRace(){
        SceneManager.LoadScene(3);
    }
    public void ChillRun(){
        SceneManager.LoadScene(4);
    }
    public void SidestepChallenge(){
        SceneManager.LoadScene(5);
    }
    public void MenuReturn(){
        SceneManager.LoadScene(0);
    }
    public void QuitGame(){
        Application.Quit();
        EditorApplication.isPlaying = false;
    }

}