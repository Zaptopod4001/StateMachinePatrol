using System.Collections;
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


    public class WanderState : IState
    {
        FSM fsm;
        FSMTest owner;

        // local
        Vector3 nextTarget;
        bool idling;

        public WanderState(FSMTest parent)
        {
            this.owner = parent;
            this.fsm = parent.fsm;
        }


        // interface -------

        public void OnEnter()
        {
            Debug.Log("Entered state wander");
            nextTarget = GetRandomPos();
            fsm.tra.GetComponent<SpriteRenderer>().color = Color.cyan;
        }

        public void OnExit()
        {
            Debug.Log("Exit state wander");
        }

        public void OnUpdate()
        {
            WanderAction();
        }



        // actions --------

        void WanderAction()
        {
            if (idling) return;

            if (Vector3.Distance(nextTarget, fsm.tra.position) > owner.stopDistance)
            {
                fsm.tra.position = Vector3.MoveTowards(fsm.tra.position, nextTarget, owner.moveSpeed * Time.deltaTime);
            }
            else
            {
                owner.StartCoroutine(IdleAction());
            }
        }

        IEnumerator IdleAction()
        {
            Debug.Log("Idling");

            idling = true;
            yield return new WaitForSeconds(owner.pauseLength);
            idling = false;

            nextTarget = GetRandomPos();
        }


        Vector3 GetRandomPos()
        {
            var distX = owner.wanderArea.x / 2f;
            var distY = owner.wanderArea.y / 2f;

            return new Vector3(Random.Range(-distX, distX), Random.Range(-distY, distY), 0);
        }

    }

}