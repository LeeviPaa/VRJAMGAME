using UnityEngine;
using System.Collections;

public class VRPlayer : MonoBehaviour
{
    private VRHand leftHand;
    private VRHand rightHand;

    void Start()
    {
        VRHand[] hands = GetComponentsInChildren<VRHand>();

        for (int i = 0; i < hands.Length; i++)
        {
            if (hands[i].hand == VRHand.ControllerIndex.Left)
            {
                leftHand = hands[i];
            }
            else if (hands[i].hand == VRHand.ControllerIndex.Right)
            {
                rightHand = hands[i];
            }
        }
    }

    void Update()
    {
        Input();
    }

    void Input()
    {
        Vector2 rightTriggerAxis = rightHand.GetTriggerAxis();
        Vector2 leftTriggerAxis = leftHand.GetTriggerAxis();

        print(rightTriggerAxis + " Right trigger");
        print(leftTriggerAxis + " Left trigger");

        if (rightTriggerAxis.x > 0.5f || rightTriggerAxis.y > 0.5f)
        {
            rightHand.ability1.UseAbility();
        }

        if (leftTriggerAxis.x > 0.5f || leftTriggerAxis.y > 0.5f)
        {
            leftHand.ability1.UseAbility();
        }
    }
}
