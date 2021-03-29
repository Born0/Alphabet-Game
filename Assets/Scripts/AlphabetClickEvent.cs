﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AlphabetClickEvent : MonoBehaviour
{

    public GameObject sourceDest;

    public List<GameObject> sourceObject = new List<GameObject>();

    [SerializeField]
    private GameObject currentObject;

    // Start is called before the first frame update
    void Start()
    {
        currentObject = sourceObject[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AlphabetPress()
    {
        string alphabet = EventSystem.current.currentSelectedGameObject.GetComponent<Button>().GetComponentInChildren<Text>().text;
        if(alphabet=="A")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[0];
            currentObject.SetActive(true);
        }
        else if(alphabet == "B")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[1];
            currentObject.SetActive(true);
        }
        else if (alphabet == "C")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[2];
            currentObject.SetActive(true);
        }
        else if (alphabet == "D")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[3];
            currentObject.SetActive(true);
        }
        else if (alphabet == "E")
        {
            currentObject.SetActive(false);
            currentObject = sourceObject[4];
            currentObject.SetActive(true);
        }
    }
}