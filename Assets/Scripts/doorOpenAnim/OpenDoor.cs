using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private Animator localAnim;
    public Animator HandAnim;
    private void Start()
    {
        localAnim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        localAnim.SetTrigger("Open");
        HandAnim.SetTrigger("Hide");
    }
}
