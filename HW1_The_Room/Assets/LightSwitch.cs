using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public Light light;
    public InputActionReference action;

    void Start () {
        light = GetComponent<Light>();
        action.action.Enable();
        action.action.performed += ButtonPressed;
    }

    private void ButtonPressed(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            if (light.color != Color.red)
            {
                light.color = Color.red;
            }
            else
            {
                light.color = Color.white;
            }
        }
    }

}
