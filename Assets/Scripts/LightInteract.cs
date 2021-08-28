using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightInteract : Interactable
{

    public Light light;
    public bool isOn;
    private void Start()
    {
        UpdateLight();
    }

    void UpdateLight()
    {
        light.enabled = isOn;
    }


    public override string GetDescription()
    {
        if (light.enabled) return "Press [I] to turn <color=red>off</color> the light.";
        return "Press [I] to turn <color=green>on</color> the light.";
    }
    public override void Interact()
    {
        isOn = !isOn;
        //light.enabled = !light.enabled;
        UpdateLight();
    }

}
