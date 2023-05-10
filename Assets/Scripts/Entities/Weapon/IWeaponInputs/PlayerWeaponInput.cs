using Entities.Tanks.PlayerTanks;
using InputSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Entities.Weapon.IWeaponInputs
{
    public class PlayerWeaponInput : IWeaponInput
    {
        private readonly PlayerInputRoot _playerInputRoot;
        private readonly PlayerTankType _tankType;
        private Vector2 _previousDirection = Vector2.zero;

        public event UnityAction<Vector2> ShootDirectionChanged;
        public event UnityAction ShootStateChanged;
        
        public PlayerWeaponInput(PlayerInputRoot playerInput, PlayerTankType tankType)
        {
            _playerInputRoot = playerInput;
            _tankType = tankType;
            Subscribe();
        }

        ~PlayerWeaponInput()
        {
            Unsubscribe();
        }

        private void Subscribe()
        {
            switch (_tankType)
            {
                case PlayerTankType.Right:
                    _playerInputRoot.LeftTankDirectionChanged += OnDirectionChanged;
                    break;
                case PlayerTankType.Left:
                    _playerInputRoot.RightTankDirectionChanged += OnDirectionChanged;
                    break;
                default:
                    Debug.LogError("Invalid PlayerTankType");
                    break;
            }
        }

        private void Unsubscribe()
        {
            switch (_tankType)
            {
                case PlayerTankType.Right:
                    _playerInputRoot.LeftTankDirectionChanged -= OnDirectionChanged;
                    break;
                case PlayerTankType.Left:
                    _playerInputRoot.RightTankDirectionChanged -= OnDirectionChanged;
                    break;
                default:
                    Debug.LogError("Invalid PlayerTankType");
                    break;
            }
        }

        private void OnDirectionChanged(Vector2 newDirection)
        {
            if ((_previousDirection == Vector2.zero) ^ (newDirection == Vector2.zero))
            {
                ShootStateChanged?.Invoke();
                _previousDirection = newDirection;
            }
            
            ShootDirectionChanged?.Invoke(newDirection);
        }
    }
}