using System.Collections.Generic;
using UnityEngine;

namespace Base
{
    public class State : MonoBehaviour
    {
        [SerializeField] private List<Transition> _transitions;

        public void Enter()
        {
            if (enabled == false)
            {
                enabled = true;

                foreach (var transition in _transitions)
                {
                    transition.enabled = true;
                }
            }
        }

        public void Exit()
        {
            if (enabled)
            {
                foreach (var transition in _transitions)
                {
                    transition.enabled = false;
                }

                enabled = false;
            }
        }

        public State GetNextState()
        {
            foreach (var transition in _transitions)
            {
                if (transition.NeedTransit)
                {
                    return transition.TargetState;
                }
            }

            return null;
        }
    }
}