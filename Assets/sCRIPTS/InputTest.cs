using UnityEngine;
using UnityEngine.InputSystem;

public class InputTest : MonoBehaviour
{
    public InputActionProperty GripAction;
    public InputActionProperty GripActionValue;
    public InputActionProperty TrigerAction;
    public InputActionProperty TrigerActionValue;
    public bool Gripbutton;
    public float GripValue;
    public bool Trigerbutton;
    public float TrigerValue;

    void Update()
    {
        Gripbutton = GripAction.action.IsPressed();
        GripValue = GripActionValue.action.ReadValue<float>();
        Trigerbutton = TrigerAction.action.IsPressed();
        TrigerValue = TrigerActionValue.action.ReadValue<float>();
    }
}
