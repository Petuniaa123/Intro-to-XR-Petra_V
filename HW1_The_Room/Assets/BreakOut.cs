using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BreakOut : MonoBehaviour
{
    public GameObject player;
    public InputActionReference action;
    public Transform[] locations;
    public int index = 0;

    void Start()
    {
        action.action.Enable();
        action.action.performed += ButtonPressed;
    }

    private void ButtonPressed(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            if (index == 0)
            {
                index = index + 1;
                player.transform.position = locations[index].position;    
            }
            else
            {
                index = 0;
                player.transform.position = locations[index].position;
            }
        }
    }

}
