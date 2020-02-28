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


    public class ChaseState : IState
    {
        FSMTest owner;
        FSM fsm;

        public ChaseState(FSMTest parent)
        {
            this.fsm = parent.fsm;
            this.owner = parent;
        }


        // interface -----

        public void OnEnter()
        {
            Debug.Log("Entered state chase");
            owner.fsm.tra.GetComponent<SpriteRenderer>().color = Color.red;
        }

        public void OnExit()
        {
            Debug.Log("Exit state chase");
        }

        public void OnUpdate()
        {
            ChaseAction();
        }



        // actions --------

        void ChaseAction()
        {
            if (fsm.target == null)
            {
                fsm.ChangeState("wander");
                return;
            }

            var dist = Vector3.Distance(fsm.tra.position, fsm.target.position);

            if (dist < owner.chaseDistance)
            {
                if (dist > owner.stopDistance)
                {
                    fsm.tra.position = Vector3.MoveTowards(fsm.tra.position, fsm.target.position, owner.moveSpeed * Time.deltaTime);
                    owner.fsm.tra.GetComponent<SpriteRenderer>().color = Color.red;
                }
                else
                {
                    owner.fsm.tra.GetComponent<SpriteRenderer>().color = Color.yellow;
                    Debug.Log("Caught player!");
                }
            }
            else
            {
                fsm.ChangeState("wander");
                return;
            }
        }

    }

}