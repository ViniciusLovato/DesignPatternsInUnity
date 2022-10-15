using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocomotionFSM : MonoBehaviour
{
    enum State
    {
        InAir,
        Grounded,
        Crouching
    }

    private State currentState;

    public void Jump()
    {
        currentState = currentState switch
        {
            State.Grounded => State.InAir,
            State.Crouching => State.Grounded,
            _ => currentState
        };
    }

    public void Fall()
    {
        currentState = currentState switch
        {
            State.Grounded => State.InAir,
            State.Crouching => State.InAir,
            _ => currentState
        };
    }

    public void Land()
    {
        currentState = currentState switch
        {
            State.InAir => State.Grounded,
            _ => currentState
        };
    }

    public void Crouch()
    {
        currentState = currentState switch
        {
            State.Grounded => State.Crouching,
            State.Crouching => State.Grounded,
            _ => currentState
            
        };
    }
}
