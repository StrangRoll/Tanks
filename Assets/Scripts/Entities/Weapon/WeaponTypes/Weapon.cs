using Entities.Bullets;
using Entities.DamagableTypes;
using Systems;
using UnityEngine;
using Zenject;

namespace Entities.Weapon.WeaponTypes
{
    public abstract class Weapon
    {
        [Inject] private TimeCounter _timeCounter;

        private readonly Transform _bulletSpawnPosition;
        private readonly WeaponInfo.WeaponInfo _weaponInfo;
        private bool _isReadyToFire;
        private bool _isFireButtonPress = false;
        private Vector2 _shootDirection;
        private DamagableEntitieTypes[] _damagableEntitiesArray;

        protected Weapon(DamagableEntitieTypes[] damagableEntitiesArray, Transform bulletSpawnPosition, 
            WeaponInfo.WeaponInfo weaponInfo)
        {
            _damagableEntitiesArray = damagableEntitiesArray;
            _bulletSpawnPosition = bulletSpawnPosition;
            _weaponInfo = weaponInfo;
        }

        public void TryShoot()
        {
            if (_isReadyToFire == false || _isFireButtonPress == false) return;
            
            Shoot(_weaponInfo.BulletSpeed, _weaponInfo.BulletPrefab, _bulletSpawnPosition, _damagableEntitiesArray);
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
        
        protected abstract void Shoot(float bulletSpeed, Bullet bulletPrefab, Transform bulletSpawnPosition, 
            DamagableEntitieTypes[] damagableEntitiesArray);
        
        private void Reload()
        {
            _timeCounter.SetTimer(_weaponInfo.ReloadTime, () => { _isReadyToFire = true;});
        }
    }
}