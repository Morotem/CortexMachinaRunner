using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using TMPro;
public class HoverButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public TextMeshProUGUI text;
    public string description;
    public string nameOfLevel;
    public void OnPointerEnter(PointerEventData eventData)
    {
        text.text = description;
        text.fontSize = 14;
        text.fontStyle = FontStyles.Normal;
    }
    public void OnPointerExit(PointerEventData eventData){
        text.fontStyle = FontStyles.Bold;
        text.text = nameOfLevel;
        text.fontSize = 20;
    }
}
