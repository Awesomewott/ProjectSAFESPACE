using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInteraction : MonoBehaviour
{
    public float interactDistance;

    public TMPro.TextMeshProUGUI interactionText;
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        Ray ray = cam.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, interactDistance))
        {
            Debug.Log("I am found");
            Interactable interactable = hit.collider.GetComponent<Interactable>();

            if(interactable != null)
            {
                HandleInteraction(interactable);
            }
        }
        
    }

    void HandleInteraction(Interactable interactable)
    {
        if(Input.GetKeyDown(KeyCode.I) == true)
        {
            Debug.Log(interactable);
            interactable.Interact();
        }
    }
}
