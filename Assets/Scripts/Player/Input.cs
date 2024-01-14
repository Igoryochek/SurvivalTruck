using Base;
using System;
using UnityEngine;

namespace Player
{
    public class Input : MonoBehaviour
    {
        [SerializeField] private VariableJoystick _joystick;

        private PlayerMover _mover;
        private Shooter _shooter;

        public event Action<Vector3> JoystickPushed;
        public event Action JoystickPulled;

        private void Start()
        {
            _mover = GetComponent<PlayerMover>();
            _shooter = GetComponent<Shooter>();
        }

        private void Update()
        {
            Vector3 newDirection = new Vector3(_joystick.Horizontal, transform.position.y, _joystick.Vertical);
            Rotate(newDirection);

            if (_joystick.Horizontal != GlobalValues.Zero && _joystick.Vertical != GlobalValues.Zero)
            {
                JoystickPushed?.Invoke(newDirection);
                return;
            }

            JoystickPulled?.Invoke();
        }

        private void Rotate(Vector3 direction)
        {
            if (_shooter.IsShooting == false)
            {
                if (_joystick.Horizontal != GlobalValues.Zero && _joystick.Vertical != GlobalValues.Zero)
                {
                    _mover.Rotate(new Vector3(transform.position.x + direction.x, transform.position.y,
                        transform.position.z + direction.z));
                }

                return;
            }

            _mover.Rotate(_shooter.Target.transform.position);
        }
    }
}