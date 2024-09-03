using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenu : MonoBehaviour
{
    public GameObject menu;
    public Transform head;
    public float spawnDistance = 2;
    public InputActionProperty showButton; 
    
    void Update()
    {
        if (showButton.action.WasPressedThisFrame())
            menu.SetActive(!menu.activeInHierarchy);

        menu.transform.position = head.transform.position + head.transform.forward * spawnDistance;
        menu.transform.LookAt(head);
        menu.transform.forward *= -1;
    }
}
