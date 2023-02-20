using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class HoverButton : MonoBehaviour, IPointerEnterHandler
{
    public string description;
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log(description);
    }
}
