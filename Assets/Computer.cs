using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour, IInteractable
{
    public void OnInteract()
    {
        //Debug.Log($"HEY HEY { GameObject.Find("ComputerCanvas - Login") }");
        GameObject.Find("ComputerCanvas - Login").GetComponent<Canvas>().enabled = true;

        Cursor.lockState = CursorLockMode.None;
    }

}
