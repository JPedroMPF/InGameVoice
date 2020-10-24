using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngameVoiceUI : MonoBehaviour
{
    Color OnColor = Color.green;
    Color OffColor = Color.red;
    public Image sttImage;
    public Image chatBotImage;
    public Text STTResult;
    public Text tutorialText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateUI()
    {
        sttImage.color = (MainController.instance.speechToText.Active == true) ? OnColor : OffColor;
    }

    internal void UpdateSTTResult(string textIN)
    {
        STTResult.text = textIN;
    }

    public void RemoveTutorialText()
    {
        tutorialText.gameObject.SetActive(false);
    }
}
