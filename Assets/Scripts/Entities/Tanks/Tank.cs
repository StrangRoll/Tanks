using Entities.Move.MoveInputs;
using Entities.Move.MoveTypes;
using Entities.Tanks.TanksViews;
using Entities.Tanks.TankViewInfos;
using Entities.Weapon.IWeaponInputs;
using Entities.Weapon.WeaponInfos;
using Systems;
using UnityEngine;

namespace Entities.Tanks
{
    [RequireComponent(typeof(Collider2D))]
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class Tank : MonoBehaviour
    {
        private TimeCounter _timeCounter;
        
        [SerializeField] private float speed;
        [SerializeField] private WeaponInfo weaponInfo;
        [SerializeField] private TankViewInfo tankViewInfo;
        [SerializeField] private SpriteRenderer weaponSpriteRenderer;
        [SerializeField] private SpriteRenderer baseSpriteRenderer;
        [SerializeField] private bool isFlip;
    
        protected Weapon.WeaponTypes.Weapon Weapon;
        protected IMoveType MoveType;
        protected IMoveInput MoveInput;
        protected IWeaponInput WeaponInput;
        
        private TankView _tankView;
        private Rigidbody2D _rigidbody2D;
        private bool _isFirstTime = true;

        private void Start()
        {
            if (_isFirstTime == false)
                return;

            _isFirstTime = false;
            _rigidbody2D = GetComponent<Rigidbody2D>();
            SetMoveType(_rigidbody2D);
            SetMoveInput(_timeCounter);
            SetWeapon(weaponInfo, _timeCounter);
            SetWeaponInput(_timeCounter);
            _tankView = new TankView(tankViewInfo, weaponSpriteRenderer, baseSpriteRenderer);

            MoveInput.DirectionChanged += OnDirectionChanged;
            WeaponInput.ShootDirectionChanged += OnShootDirectionChanged;
            WeaponInput.ShootStateChanged += OnShootStateChanged;
        }

        private void FixedUpdate()
        {
            MoveType.Move(speed);
            Weapon.TryShoot(isFlip);
        }

        private void OnDestroy()
        {
            MoveInput.DirectionChanged -= OnDirectionChanged;
            WeaponInput.ShootDirectionChanged += OnShootDirectionChanged;
            WeaponInput.ShootStateChanged -= OnShootStateChanged;
        }

        public void Init(TimeCounter timeCounter)
        {
            _timeCounter = timeCounter;
        }

        protected abstract void SetMoveType(Rigidbody2D rigidbodyToMove);

        protected abstract void SetMoveInput(TimeCounter timeCounter);

        protected abstract void SetWeapon(WeaponInfo weaponInfo, TimeCounter timeCounter);

        protected abstract void SetWeaponInput(TimeCounter timeCounter);

        private void OnShootDirectionChanged(Vector2 newDirection)
        {
            Weapon.ChangeDirection(newDirection);
            _tankView.ChangeShootDirectionView(newDirection);
        }

        private void OnDirectionChanged(Vector2 newDirection)
        {
            MoveType.ChangeDirection(newDirection);
            _tankView.ChangeMoveDirectionView(newDirection);
        }

        private void OnShootStateChanged()
        {
            Weapon.ChangeShootState();
        }
    }
}
