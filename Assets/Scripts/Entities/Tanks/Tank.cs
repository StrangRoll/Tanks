using Entities.Move.MoveInputs;
using Entities.Move.MoveTypes;
using Entities.Weapon.IWeaponInputs;
using Entities.Weapon.WeaponInfo;
using UnityEngine;

namespace Entities.Tanks
{
    public abstract class Tank : MonoBehaviour
    {
        [SerializeField] protected float Speed;
        [SerializeField] protected WeaponInfo WeaponInfo;
    
        protected Weapon.WeaponTypes.Weapon Weapon;
        protected IMoveType MoveType;
        protected IMoveInput MoveInput;
        protected IWeaponInput WeaponInput;

        private void Awake()
        {
            SetMoveType();
            SetMoveInput();
            SetWeapon();
            SetWeaponInput();
        }

        private void OnEnable()
        {
            MoveInput.DirectionChanged += OnDirectionChanged;
            WeaponInput.ShootDirectionChanged += OnShootDirectionChanged;
            WeaponInput.ShootStateChanged += OnShootStateChanged;
        }

        private void FixedUpdate()
        {
            MoveType.Move(Speed);
            Weapon.TryShoot();
        }

        private void OnDisable()
        {
            MoveInput.DirectionChanged -= OnDirectionChanged;
            WeaponInput.ShootDirectionChanged += OnShootDirectionChanged;
            WeaponInput.ShootStateChanged -= OnShootStateChanged;
        }

        protected abstract void SetMoveType();

        protected abstract void SetMoveInput();

        protected abstract void SetWeapon();

        protected abstract void SetWeaponInput();

        private void OnShootDirectionChanged(Vector2 newDirection)
        {
            Weapon.ChangeDirection(newDirection);
        }

        private void OnDirectionChanged(Vector2 newDirection)
        {
            MoveType.ChangeDirection(newDirection);
        }

        private void OnShootStateChanged()
        {
            Weapon.ChangeShootState();
        }
    }
}
