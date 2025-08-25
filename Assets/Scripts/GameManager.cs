using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour, IInteractableRaw, IInteractableEaten
{
    public TextMeshProUGUI GoWorkText;
    public TextMeshProUGUI BreakfastText;
    public GameObject RawBreakfast;
    public GameObject ReadyBreakfast;
    public GameObject EatenBreakfast;
    public TextMeshProUGUI InteractText;
    private void Awake()
    {
        
        
        EventManager.InteractionRaw += PressE_raw;
    }
    private void OnDestroy()
    {
        EventManager.InteractionRaw -= PressE_raw;
    }
    public void PressE_raw(bool istrue)
    {
        if (istrue)
        {
            InteractText.gameObject.SetActive(true);
        }
        else
            InteractText.gameObject.SetActive(false);
        
    }
    

    public void InteractRaw()
    {
        RawBreakfast.SetActive(false);        
        ReadyBreakfast.SetActive(true);
        InteractText.text = "Press E to eat *food on the table*";
    }
    public void InteractEat()
    {
        ReadyBreakfast.SetActive(false);
        EatenBreakfast.SetActive(true);
        BreakfastText.gameObject.SetActive(false);
        GoWorkText.gameObject.SetActive(true);
    }
    
}
