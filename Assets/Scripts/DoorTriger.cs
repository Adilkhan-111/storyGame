using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTriger : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;
    public GameManager gameManagerScirpt;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && gameManagerScirpt.canPlayerGo)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
