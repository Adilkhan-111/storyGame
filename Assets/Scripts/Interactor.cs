using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IInteractableRaw
{
    public void InteractRaw();
}
interface IInteractableEaten
{
    public void InteractEat();
}
public class Interactor : MonoBehaviour
{
    public Transform InteracterSource;
    public GameObject GameManager;
    
    public float InteractRange;
    
    
    void Update()
    {        
        Ray r = new Ray(InteracterSource.position, InteracterSource.forward);
        if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
        {
                
            if (hitInfo.collider.tag == "RawBreakfast")
            {
                EventManager.OnInteractionRaw(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    GameManager.TryGetComponent(out IInteractableRaw gamemanager);
                    gamemanager.InteractRaw();
                    
                }
            }
            else if (hitInfo.collider.tag == "ReadyBreakfast")
            {
                EventManager.OnInteractionRaw(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    GameManager.TryGetComponent(out IInteractableEaten gamemanagerEaten);
                    gamemanagerEaten.InteractEat();
                }
            }
            else
            {
                EventManager.OnInteractionRaw(false);
                Debug.Log("No hit");
            }
        }
    }
}
