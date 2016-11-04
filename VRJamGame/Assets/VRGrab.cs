using UnityEngine;
using System.Collections;
using Valve.VR;
using VRTK;

[RequireComponent(typeof(Collider))]
public class VRGrab : VRAbility
{
    public Vector3 grabPositionOffset;
    public Vector3 grabRotationOffset;

    private Collider grabCollider;
    private VRInteractable grabbedObj = null;
    private Rigidbody cachedGrabbedRb = null;
    private bool grabActive = false;

    private Rigidbody grabbedRb
    {
        get
        {
            if (cachedGrabbedRb)
            {
                return cachedGrabbedRb;
            }
            else if (!cachedGrabbedRb && grabbedObj)
            {
                return cachedGrabbedRb = grabbedObj.GetComponent<Rigidbody>();
            }
            else
            {
                return null;
            }
        }
    }

    void Start()
    {
        grabCollider = GetComponent<Collider>();
    }

    void Update()
    {
        if (grabbedObj)
        {
            if (grabActive)
            {
                if (grabbedRb)
                {
                    grabbedRb.MovePosition(transform.position + grabPositionOffset);
                    grabbedRb.MoveRotation(Quaternion.Euler(grabRotationOffset) * transform.rotation * Quaternion.identity);
                }
                else
                {
                    grabbedObj.transform.position = transform.position + grabPositionOffset;
                    grabbedObj.transform.rotation = Quaternion.Euler(grabRotationOffset) * transform.rotation * Quaternion.identity;
                }
            }
            else
            {
                grabbedObj = null;
            }
        }
    }

    public override void ActivateAbility()
    {
        grabActive = true;
    }

    public override void DeactivateAblity()
    {
        grabActive = false;
    }

    void OnTriggerStay(Collider col)
    {
        if (grabActive)
        {
            if (!grabbedObj)
            {
                VRInteractable interactable = col.GetComponent<VRInteractable>();

                if (interactable)
                {
                    grabbedObj = interactable;
                }
            }
        } 
    }
}
