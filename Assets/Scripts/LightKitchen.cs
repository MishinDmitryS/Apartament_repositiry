using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightKitchen : MonoBehaviour
{
    public Light lightK;

    public void EnabledLight()
    {
        if(!lightK.enabled)
        {
            lightK.enabled = true;
        } else
        {
            lightK.enabled = false;
        }
    }
}
