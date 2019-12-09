using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartState : State
{
    //This is the basic setup for a state
    public StartState(BasicStateController stateController) : base(stateController) { }

    public override void OnStateEnter()
    {
        //This will trigger when the AI enters this state
        base.OnStateEnter();
    }

    public override void Act()
    {
        //This happens during the update fuction.
    }

    public override void CheckTransitions()
    {
        //This happens during update as well, Put checks to determine if the AI should stay in this state
    }

    public override void OnStateExit()
    {
        //This is done when the AI leaves this state
        base.OnStateExit();
    }
}
