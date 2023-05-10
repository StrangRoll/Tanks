using Entities.DamagableTypes;
using Systems;
using UnityEngine;
using UnityEngine.UIElements;
using Zenject;

namespace Entities.Weapon.WeaponTypes
{
    public abstract class Weapon
    {
        [Inject] private TimeCounter _timeCounter;
        
        private bool _isReadyToFire;
        private bool _isFireButtonPress = false;
        private float _reloadTime;
        private Vector2 _shootDirection;
        private DamagableEntitieTypes[] _damagableEntitiesArray;

        public Weapon(DamagableEntitieTypes[] damagableEntitiesArray)
        {
            _damagableEntitiesArray = damagableEntitiesArray;
        }

        public void TryShoot()
        {
            if (_isReadyToFire == false || _isFireButtonPress == false) return;
            
            Shoot();
            Reload();
        }

        public void ChangeDirection(Vector2 newDirection)
        {
            _shootDirection = newDirection;
        }

        public void ChangeShootState()
        {
            _isFireButtonPress = !_isFireButtonPress;
        }
        
        protected abstract void Shoot();
        
        private void Reload()
        {
            _timeCounter.SetTimer(_reloadTime, () => { _isReadyToFire = true;});
        }
    }
}