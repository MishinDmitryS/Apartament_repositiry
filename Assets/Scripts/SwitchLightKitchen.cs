using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLightKitchen : MonoBehaviour
{
    [SerializeField] private Light light1;
    [SerializeField] private Light light2;

    public void EnableLightSwitch()
    {
        if(!light1.enabled)
        {
            light1.enabled = true;
            light2.enabled = true;
        } else
        {
            light1.enabled = false;
            light2.enabled = false;
        }
    }
}
