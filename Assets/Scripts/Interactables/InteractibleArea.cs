﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractibleArea : MonoBehaviour
{
    public GameObject elementToShow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "MainCharacter")
            elementToShow.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "MainCharacter")
            elementToShow.SetActive(false);
    }

}
