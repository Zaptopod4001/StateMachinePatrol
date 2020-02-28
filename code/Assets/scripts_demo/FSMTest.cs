using System.Collections;
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


    public class FSMTest : MonoBehaviour
    {
        
        public FSM fsm;

        public Vector3 wanderArea = new Vector3(10, 10);
        public float moveSpeed = 2f;
        public float stopDistance = 0.5f;
        public float chaseDistance = 6f;
        public float pauseLength = 1f;

        void Start()
        {
            fsm = new FSM();
            fsm.Init(this.transform);
            fsm.states.Add("wander", new WanderState(this));
            fsm.states.Add("chase", new ChaseState(this));
            fsm.ChangeState("wander");
        }

        void Update()
        {
            fsm.Update();
        }
        
        void OnTriggerEnter2D(Collider2D other)
        {
            fsm.target = other.transform;
            fsm.ChangeState("chase");
        }

    }

}
