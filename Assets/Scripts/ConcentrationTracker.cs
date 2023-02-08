using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConcentrationTracker : MonoBehaviour
{
    public PlayerMovement player;
    public string prefixe = "Concentration : ";
    public TextMeshProUGUI textComponent;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = PlayerMovement.MAX_CONCENTRATION_VALUE;
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = prefixe + player.concentration.ToString();
        slider.value = player.concentration;
    }
}
