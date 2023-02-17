using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Menu : MonoBehaviour
{
    void Start() {
        toggle.onValueChanged.AddListener(OnToggleValueChanged);
    }
    public Toggle toggle;
    public void GoToLevelChoice(){
        SceneManager.LoadScene(1);
    }
    public void AdminMenu(){
        SceneManager.LoadScene(2);
    }
    public void StrainghtRace(){
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
    public void OnToggleValueChanged(bool value)
{
    GameObject button = GameObject.Find("StrainghtRace");
    if (button != null)
    {
        button.SetActive(value);
    }
}
    
}