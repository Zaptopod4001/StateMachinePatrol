using System.Collections.Generic;
using UnityEngine;

namespace Eses.FSM
{
    // Copyright 
    // Created by Sami S. 

    // use of any kind without a written permission 
    // from the author is not allowed.

    // DO NOT:
    // Fork, clone, copy or use in any shape or form.

    // WHY?
    // This piece of code is here only to show my coding skills
    // and for employment evaluation purposes.


    public class FSM
    {
        public Dictionary<string, IState> states;
        public IState currentState;
        public Transform tra;
        public Transform target;

        public void Init(Transform tra)
        {
            this.states = new Dictionary<string, IState>();
            this.tra = tra;
            Debug.Log("FSM Init");
        }

        public void Update()
        {
            currentState.OnUpdate();
        }

        public void ChangeState(string stateName)
        {
            if (currentState != null)
                currentState.OnExit();

            currentState = states[stateName];
            currentState.OnEnter();
        }
    }

}
