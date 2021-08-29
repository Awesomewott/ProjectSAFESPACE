using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInteraction : MonoBehaviour
{
    public float interactDistance;

    public TMPro.TextMeshProUGUI interactionText;
    private Camera cam;
    bool checkIsThere;

    [SerializeField]
    MusicBoxInteract musicInteract;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        Ray ray = cam.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));
        RaycastHit hit;

        bool successfulHit = false;

        if (Physics.Raycast(ray, out hit, interactDistance))
        {
            Debug.Log("I am found");
            Interactable interactable = hit.collider.GetComponent<Interactable>();

            if (interactable != null)
            {
                HandleInteraction(interactable);
                interactionText.text = interactable.GetDescription();
                successfulHit = true;
                if (interactable.tag == "Music")
                {
                    checkIsThere = true;
                }

                else checkIsThere = false;
            }
        }

            

        

        if (!successfulHit) interactionText.text = "";

    }

    void HandleInteraction(Interactable interactable)
    {
        if(Input.GetKeyDown(KeyCode.I) == true)
        {
            Debug.Log(interactable);
            interactable.Interact();
        }

        if(checkIsThere == true)
        {
            if(Input.GetKeyDown(KeyCode.Q) == true)
            {
                musicInteract.changeSong(-1);
            }

            else if(Input.GetKeyDown(KeyCode.E) == true)
            {
                musicInteract.changeSong(1);
            }
        }
    }
}
