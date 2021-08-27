using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightInteract : Interactable
{

    public Light light;
    public override void Interact()
    {
        light.enabled = !light.enabled;
    }

    public override void GetDescription()
    {
        throw new System.NotImplementedException();
    }


}
