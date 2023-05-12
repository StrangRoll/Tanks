using Entities.Bullets;
using Entities.DamagableTypes;
using Entities.Weapon.WeaponInfos;
using Systems;
using UnityEngine;
using Bullet = Entities.Bullets.Bullet;

namespace Entities.Weapon.WeaponTypes
{
    public abstract class Weapon
    {
        private TimeCounter _timeCounter;
        private readonly Transform _bulletSpawnPosition;
        private readonly WeaponInfo _weaponInfo;
        private bool _isReadyToFire = true;
        private bool _isFireButtonPress = false;
        private Vector2 _shootDirection;
        private DamagableEntitieTypes[] _damagableEntitiesArray;

        protected Weapon(DamagableEntitieTypes[] damagableEntitiesArray, Transform bulletSpawnPosition, 
            WeaponInfo weaponInfo, TimeCounter timeCounter)
        {
            _damagableEntitiesArray = damagableEntitiesArray;
            _bulletSpawnPosition = bulletSpawnPosition;
            _weaponInfo = weaponInfo;
            _timeCounter = timeCounter;
        }

        public void TryShoot(bool isFlip)
        {
            if (_isReadyToFire == false || _isFireButtonPress == false) return;
            
            Shoot(_weaponInfo.BulletSpeed, _weaponInfo.BulletPrefab, _shootDirection, _bulletSpawnPosition, _damagableEntitiesArray, isFlip);
            _isReadyToFire = false;
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
        
        protected abstract void Shoot(float bulletSpeed, Bullet bulletPrefab, Vector2 shootDirection, 
            Transform bulletSpawnPosition, DamagableEntitieTypes[] damagableEntitiesArray, bool isFlip);
        
        private void Reload()
        {
            _timeCounter.SetTimer(_weaponInfo.ReloadTime, () => { _isReadyToFire = true;});
        }
    }
}