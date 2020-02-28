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

    public interface IState
    {
        void OnExit();
        void OnEnter();
        void OnUpdate();
    }

}