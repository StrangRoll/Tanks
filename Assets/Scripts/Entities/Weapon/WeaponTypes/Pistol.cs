using Entities.Bullets;
using Entities.DamagableTypes;
using Entities.Weapon.WeaponInfos;
using NTC.Global.Pool;
using Systems;
using UnityEngine;

namespace Entities.Weapon.WeaponTypes
{
    public class Pistol : Weapon
    {
        public Pistol(DamagableEntitieTypes[] damagableEntitiesArray, Transform bulletSpawnPosition, WeaponInfo weaponInfo, TimeCounter timeCounter) : base(damagableEntitiesArray, bulletSpawnPosition, weaponInfo, timeCounter)
        {
        }

        protected override void Shoot(float bulletSpeed, Bullet bulletPrefab, Vector2 shootDirection,
        Transform bulletSpawnPosition, DamagableEntitieTypes[] damagableEntitiesArray)
        {
            var newBullet = NightPool.Spawn(bulletPrefab, bulletSpawnPosition, Quaternion.identity);
            newBullet.Init(damagableEntitiesArray, shootDirection, bulletSpeed);
        }
    }
}