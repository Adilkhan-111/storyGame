using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour, IInteractableRaw, IInteractableEaten
{
    [Header("thoughs")]
    public TextMeshProUGUI BreakfastText;
    public TextMeshProUGUI GoWorkText;

    public TextMeshProUGUI InteractText;

    [Header("Breakfast States")]
    public GameObject RawBreakfast;
    public GameObject ReadyBreakfast;
    public GameObject EatenBreakfast;
    public bool canPlayerGo;
    public GameObject Door;
    private void Awake()
    {
        EventManager.InteractionRaw += PressE_raw; // show press option whenever player aims on plate
    }
    private void OnDestroy()
    {
        EventManager.InteractionRaw -= PressE_raw; // unscribe when gameobject gets destroyed
    }
    public void PressE_raw(bool istrue) // show press option
    {
        if (istrue)
        {
            InteractText.gameObject.SetActive(true);
        }
        else
            InteractText.gameObject.SetActive(false);
        
    }
    

    public void InteractRaw() // breakfast is ready and moving it to table
    {
        RawBreakfast.SetActive(false);        
        ReadyBreakfast.SetActive(true);
        InteractText.text = "Press E to eat *food on the table*";
    }
    public void InteractEat() // player have eaten and needs to go work
    {
        ReadyBreakfast.SetActive(false);
        EatenBreakfast.SetActive(true);
        BreakfastText.gameObject.SetActive(false);
        GoWorkText.gameObject.SetActive(true);
        canPlayerGo = true;
    }

    
}
