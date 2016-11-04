using UnityEngine;
using System.Collections;
using VRTK;

[RequireComponent(typeof(Rigidbody))]
public class VRHand : MonoBehaviour
{
    public enum ControllerIndex { Left = 0, Right = 1 }

    public ControllerIndex hand;
    public VRAbility ability1;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (hand == ControllerIndex.Left)
        {
            rb.MovePosition(VRTK_SDK_Bridge.GetControllerLeftHand().transform.position);
            rb.MoveRotation(VRTK_SDK_Bridge.GetControllerLeftHand().transform.rotation);
        }
        else if (hand == ControllerIndex.Right)
        {
            rb.MovePosition(VRTK_SDK_Bridge.GetControllerRightHand().transform.position);
            rb.MoveRotation(VRTK_SDK_Bridge.GetControllerRightHand().transform.rotation);
        }
    }

    public Vector2 GetTriggerAxis()
    {
        return VRTK_SDK_Bridge.GetTriggerAxisOnIndex((uint)hand);
    }
}
