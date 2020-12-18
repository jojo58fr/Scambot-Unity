using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginView : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void QuitSession()
    {
        this.GetComponent<Canvas>().enabled = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void SessionOne()
    {
        this.GetComponent<Canvas>().enabled = true;
        GameObject.Find("ComputerCanvas - Messenger").GetComponent<Canvas>().enabled = true;
    }

    public void SessionTwo()
    {
        //
    }
}
