using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ConcentrationTracker : MonoBehaviour
{
    public PlayerMovement player;
    public string prefixe = "Concentration : ";
    public TextMeshProUGUI textComponent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = prefixe + player.concentration.ToString();
    }
}
