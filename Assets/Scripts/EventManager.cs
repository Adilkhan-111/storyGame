using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static event Action<bool> InteractionRaw;
    
    public static void OnInteractionRaw(bool isCooked)
    {
        InteractionRaw?.Invoke(isCooked);
    }

    
}
