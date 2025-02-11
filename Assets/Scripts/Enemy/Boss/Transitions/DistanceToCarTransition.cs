using Base;
using UnityEngine;

namespace Enemy
{
    public class DistanceToCarTransition : Transition
    {
        [SerializeField] private Transform _target;
        [SerializeField] private float _transitionRange;

        private void Update()
        {
            if (_target.position.z - transform.position.z < _transitionRange)
            {
                NeedTransit = true;
            }
        }
    }
}