using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour, IInteractableRaw
{
    
    public GameObject RawBreakfast;
    public GameObject ReadyBreakfast;
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
    /*public void PressE_ready(bool istrue)
    {
        if (istrue)
        {
            
            InteractText.gameObject.SetActive(true);
        }
        else
            InteractText.gameObject.SetActive(false);

    }*/

    public void InteractRaw()
    {
        RawBreakfast.SetActive(false);        
        ReadyBreakfast.SetActive(true);
        InteractText.text = "Press E to eat *food on the table*";
    }
    
}
