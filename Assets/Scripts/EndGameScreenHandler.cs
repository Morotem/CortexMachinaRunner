using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndGameScreenHandler : MonoBehaviour
{
    public TextMeshProUGUI contextText;   
    public TextMeshProUGUI endTimer;
    public TextMeshProUGUI initialTimer;

    public GameObject background;
    // Start is called before the first frame update
    void Start()
    {
        this.background.SetActive(false);
        this.contextText.enabled = false;
        this.endTimer.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Display(string newContextText){
        this.background.SetActive(true);
        this.contextText.enabled = true;
        this.endTimer.enabled = true;
        endTimer.text = "Timer : " + initialTimer.text + "s";
        
        this.contextText.text = newContextText;
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(0);
    }
}
