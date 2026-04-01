using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimation : MonoBehaviour
{
    public InputActionProperty GripValue;
    public InputActionProperty TrigerValue;
    public Animator HandAnimator;

    void Update()
    {
        float grip = GripValue.action.ReadValue<float>();
        float triger = TrigerValue.action.ReadValue<float>();

        HandAnimator.SetFloat("Grip", grip);
        HandAnimator.SetFloat("Triger", triger);
    }
}
