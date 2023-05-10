using Entities.Bullets;
using Entities.DamagableTypes;
using NTC.Global.Pool;
using UnityEngine;

namespace Entities.Weapon.WeaponTypes
{
    public class Pistol : Weapon
    {
        public Pistol(DamagableEntitieTypes[] damagableEntitiesArray, Transform bulletSpawnPosition, WeaponInfo.WeaponInfo weaponInfo) : base(damagableEntitiesArray, bulletSpawnPosition, weaponInfo)
        {
            
        }

        protected override void Shoot(float bulletSpeed, Bullet bulletPrefab, Transform bulletSpawnPosition, 
            DamagableEntitieTypes[] damagableEntitiesArray)
        {
            var newBullet = NightPool.Spawn(bulletPrefab, bulletSpawnPosition, Quaternion.identity);
            newBullet.Init(damagableEntitiesArray, bulletSpawnPosition.position, bulletSpeed);
        }
    }
}