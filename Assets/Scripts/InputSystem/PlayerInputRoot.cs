using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace InputSystem
{
    public class PlayerInputRoot : MonoBehaviour
    {
        private PlayerInput _playerInput;
        private Vector2 _lastLeftDirection = Vector2.zero;
        private Vector2 _lastRightDirection = Vector2.zero;
        private Vector2 _lastKeyPressed;

        public event UnityAction<Vector2> LeftTankDirectionChanged;
        public event UnityAction<Vector2> RightTankDirectionChanged;


        private void OnEnable()
        {
            _playerInput = new PlayerInput();
            _playerInput.Enable();
            _playerInput.Tanks.LeftMove.performed += OnLeftMove;
            _playerInput.Tanks.RightMove.performed += OnRightMove;
        }

        private void OnLeftMove(InputAction.CallbackContext context)
        {
            var direction = context.ReadValue<Vector2>();
            direction = ChangeDirection(direction, _lastLeftDirection);

            _lastLeftDirection = direction;
            LeftTankDirectionChanged?.Invoke(direction);
        }

        private void OnRightMove(InputAction.CallbackContext context)
        {
            var direction = context.ReadValue<Vector2>();
            direction = ChangeDirection(direction, _lastRightDirection);

            _lastRightDirection = direction;
            RightTankDirectionChanged?.Invoke(direction);
        }

        private Vector2 ChangeDirection(Vector2 direction, Vector2 lastDirection)
        {
            if (direction.x == 0 || direction.y == 0)
            {
                return direction;
            }
            
            if (lastDirection.x != 0)
                direction.x = 0;
            else
                direction.y = 0;

            return direction.normalized;
        }
    }
}
