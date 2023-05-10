using System;
using Entities.Move.MoveInputs;
using Entities.Move.MoveTypes;
using UnityEngine;

namespace Entities.Tanks
{
    public abstract class Tank : MonoBehaviour
    {
        [SerializeField] protected float Speed;
    
        protected Weapon.Weapon Weapon;
        protected IMoveType MoveType;
        protected IMoveInput MoveInput;

        private void Awake()
        {
            SetMoveType();
            SetMoveInput();
            SetWeapon();
        }

        private void OnEnable()
        {
            MoveInput.DirectionChanged += OnDirectionChanged;
        }

        private void Update()
        {
            MoveType.Move(Speed);
        }

        private void OnDisable()
        {
            MoveInput.DirectionChanged -= OnDirectionChanged;
        }

        protected abstract void SetMoveType();
        protected abstract void SetMoveInput();
        protected abstract void SetWeapon();

        private void OnDirectionChanged(Vector2 newDirection)
        {
            MoveType.ChangeDirection(newDirection);
        }
    }
}
