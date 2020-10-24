using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public static MainController instance = null;

    public STTService speechToText;
    public IngameVoiceUI ingameVoiceUI;
   

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);       
    }


    // Start is called before the first frame update
    void Start()
    {
        GrabReferences();

    }

    private void GrabReferences()
    {
        speechToText = transform.GetComponent<STTService>();
        ingameVoiceUI = GameObject.FindGameObjectWithTag("UI").GetComponent<IngameVoiceUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            SwitchRecordingSpeech(true);
            TurnOffTutorialText();
        }
        if (Input.GetKey(KeyCode.Alpha2))
            SwitchRecordingSpeech(false);

    }

    private void TurnOffTutorialText()
    {
        ingameVoiceUI.RemoveTutorialText();
    }

    #region STT
    public void SwitchRecordingSpeech(bool newState)
    {
        // speechToText.Active = !speechToText.Active; ISTO DAVA ERRO...CENAS
        speechToText.Active = newState;
        ingameVoiceUI.UpdateUI();
    }

    public void HandleSTTResponse(string text)
    {
        ingameVoiceUI.UpdateSTTResult(text);
    }
    #endregion




}
