using Entities.Move.MoveInputs;
using Entities.Move.MoveTypes;
using Entities.Tanks.TanksViews;
using Entities.Tanks.TankViewInfos;
using Entities.Weapon.IWeaponInputs;
using Entities.Weapon.WeaponInfos;
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
        [SerializeField] private TankViewInfo tankViewInfo;
        [SerializeField] private SpriteRenderer weaponSpriteRenderer;
        [SerializeField] private SpriteRenderer baseSpriteRenderer;
    
        protected Weapon.WeaponTypes.Weapon Weapon;
        protected IMoveType MoveType;
        protected IMoveInput MoveInput;
        protected IWeaponInput WeaponInput;
        
        private TankView _tankView;

        private void Awake()
        {
            SetMoveType();
            SetMoveInput();
            SetWeapon(weaponInfo, _timeCounter);
            SetWeaponInput();
            _tankView = new TankView(tankViewInfo, weaponSpriteRenderer, baseSpriteRenderer);
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
