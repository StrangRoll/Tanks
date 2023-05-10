using System;
using Entities.Tanks.PlayerTanks;
using InputSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Entities.Move.MoveInputs
{
    public class PlayerMoveInput : IMoveInput
    {
        private readonly PlayerInputRoot _playerInputRoot;
        private readonly PlayerTankType _tankType;

        public event UnityAction<Vector2> DirectionChanged;
        
        public PlayerMoveInput(PlayerInputRoot playerInput, PlayerTankType tankType)
        {
            _playerInputRoot = playerInput;
            _tankType = tankType;
            Subscribe();
        }

        ~PlayerMoveInput()
        {
            Unsubscribe();
        }

        private void Subscribe()
        {
            switch (_tankType)
            {
                case PlayerTankType.Left:
                    _playerInputRoot.LeftTankDirectionChanged += OnDirectionChanged;
                    break;
                case PlayerTankType.Right:
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
                case PlayerTankType.Left:
                    _playerInputRoot.LeftTankDirectionChanged -= OnDirectionChanged;
                    break;
                case PlayerTankType.Right:
                    _playerInputRoot.RightTankDirectionChanged -= OnDirectionChanged;
                    break;
                default:
                    Debug.LogError("Invalid PlayerTankType");
                    break;
            }
        }

        private void OnDirectionChanged(Vector2 newDirection)
        {
            DirectionChanged?.Invoke(newDirection);
        }
    }
}