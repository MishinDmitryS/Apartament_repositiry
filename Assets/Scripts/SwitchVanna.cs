using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchVanna : MonoBehaviour
{
    [SerializeField] private Light light1;

    public void EnableLightSwitch()
    {
        if (!light1.enabled)
        {
            light1.enabled = true;
        }
        else
        {
            light1.enabled = false;
        }
    }
}
