using Entities.Move.MoveInputs;
using Entities.Move.MoveTypes;
using Entities.Weapon.IWeaponInputs;
using Entities.Weapon.WeaponInfo;
using Systems;
using UnityEngine;
using Zenject;

namespace Entities.Tanks
{
    public abstract class Tank : MonoBehaviour
    {
        [Inject] private TimeCounter _timeCounter;
        
        [SerializeField] private float speed;
        [SerializeField] private WeaponInfo weaponInfo;
    
        protected Weapon.WeaponTypes.Weapon Weapon;
        protected IMoveType MoveType;
        protected IMoveInput MoveInput;
        protected IWeaponInput WeaponInput;

        private void Awake()
        {
            SetMoveType();
            SetMoveInput();
            SetWeapon(weaponInfo, _timeCounter);
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
            MoveType.Move(speed);
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

        protected abstract void SetWeapon(WeaponInfo weaponInfo, TimeCounter timeCounter);

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
