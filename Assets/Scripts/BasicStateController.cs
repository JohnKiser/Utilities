using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class BasicStateController : MonoBehaviour
{
    public State currentState;
    public GameObject goal;

    public NavMeshAgent agent;

    public bool Winner = false;


    // Start is called before the first frame update
    void Start()
    {
        //Set
        agent = GetComponent<NavMeshAgent>();
        SetState(new StartState(this));
    }

    // Update is called once per frame
    void Update()
    {
        //This is where you run the 2 functions in each state

        currentState.CheckTransitions();
        currentState.Act();
        
        // print(currentState);
    }

    public void SetState(State state)
    {
        //This sets the new state triggereing the on enter and exit state functions
        if (currentState != null)
        {
            currentState.OnStateExit();
        }

        currentState = state;
        gameObject.name = "AI agent in state " + state.GetType().Name;

        if (currentState != null)
        {
            currentState.OnStateEnter();
        }
    }
}
