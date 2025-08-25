using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//interfaces to gameManager
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
    public float InteractRange;

    public GameObject GameManager;
    
    
    
    
    void Update()
    {
        interaction();
    }

    private void interaction()
    {
        Ray r = new Ray(InteracterSource.position, InteracterSource.forward);
        if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
        {
            //Show press option
            EventManager.OnInteractionRaw(true);
            
            switch (hitInfo.collider.tag)
            {
                case "RawBreakfast":

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        //changing breakfast position to table
                        GameManager.TryGetComponent(out IInteractableRaw gamemanager);
                        gamemanager.InteractRaw();

                    }
                    break;
                case "ReadyBreakfast":

                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        //changing breakfast to eaten and setting gotowork text
                        GameManager.TryGetComponent(out IInteractableEaten gamemanagerEaten);
                        gamemanagerEaten.InteractEat();
                    }
                    break;
                default:
                    //if player doesn`t aim to plate = doesn`t hide press option
                    EventManager.OnInteractionRaw(false);
                    
                    break;
            }


        }
    }
}
