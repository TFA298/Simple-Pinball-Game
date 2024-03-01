using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode input;
    private float targetPressed;
    private float targetRelease;
    private HingeJoint hingeJnt;
    
    void Start()
    {
        hingeJnt = GetComponent<HingeJoint>();

        targetPressed = hingeJnt.limits.max;
        targetRelease = hingeJnt.limits.min;
    }

    // Update is called once per frame
    void Update()
    {
        readInput();
    }

    private void readInput()
    {
        JointSpring jointSpring = hingeJnt.spring;
        if(Input.GetKey(input))
        {
            jointSpring.targetPosition = targetPressed;
        }
        else
        {
            jointSpring.targetPosition = targetRelease;
        }
        
        hingeJnt.spring = jointSpring;
    }
}
