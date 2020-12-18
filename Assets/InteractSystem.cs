using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteractSystem : MonoBehaviour
{
    IInteractable currentTarget;
    Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        
        
        //Debug.DrawRay(ray.origin, ray.direction * 10, Color.red);
        //Debug.Log($"Mouse: {Input.mousePosition}");

        if (Physics.Raycast(ray, out hit, 2))
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();

            Debug.Log($"COUCOU {interactable}");


            if (interactable != null)
            {
                GameObject.Find("ActionText").GetComponent<TextMeshProUGUI>().enabled = true;
                if (Input.GetMouseButtonDown(0))
                {
                    interactable.OnInteract();
                }
            }
            else
            {
                GameObject.Find("ActionText").GetComponent<TextMeshProUGUI>().enabled = false;
            }

        }
        else
        {
            GameObject.Find("ActionText").GetComponent<TextMeshProUGUI>().enabled = false;
        }
    }
}
