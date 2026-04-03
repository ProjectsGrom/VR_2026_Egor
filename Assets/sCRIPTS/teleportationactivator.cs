using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Filtering;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public InputActionProperty TeleportActiv;
    public XRRayInteractor TeleportInteractorp;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TeleportInteractorp.gameObject.SetActive(false);
        TeleportActiv.action.performed += ActionPerformed;

    }

    private void ActionPerformed(InputAction.CallbackContext obj)
    {
        TeleportInteractorp.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (TeleportActiv.action.WasReleasedThisFrame()) 
        {
            TeleportInteractorp.gameObject.SetActive(false);
        }
    }
}
