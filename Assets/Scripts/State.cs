using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    //This is the frame of a state script. This is used in order to use different states.
    //Each state extends this class
    protected BasicStateController stateController;

    public State(BasicStateController stateController)
    {
        this.stateController = stateController;
    }
    public abstract void CheckTransitions();

    public abstract void Act();

    public virtual void OnStateEnter() { }

    public virtual void OnStateExit() { }

}
