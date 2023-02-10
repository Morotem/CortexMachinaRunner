using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        string ClickedButtonName = EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(ClickedButtonName);
        if(ClickedButtonName == "Scene1" || ClickedButtonName == "PlayButton"){
            SceneManager.LoadScene(1);
        }
        if(ClickedButtonName == "Scene2"){
            SceneManager.LoadScene(2);
        }       
    }
}