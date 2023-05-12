using Entities.Bullets;
using Entities.DamagableTypes;
using Entities.Weapon.WeaponInfos;
using NTC.Global.Pool;
using Systems;
using UnityEngine;
using Bullet = Entities.Bullets.Bullet;

namespace Entities.Weapon.WeaponTypes
{
    public class Pistol : Weapon
    {
        public Pistol(DamagableEntitieTypes[] damagableEntitiesArray, Transform bulletSpawnPosition, WeaponInfo weaponInfo, TimeCounter timeCounter) : base(damagableEntitiesArray, bulletSpawnPosition, weaponInfo, timeCounter)
        {
        }

        protected override void Shoot(float bulletSpeed, Bullet bulletPrefab, Vector2 shootDirection,
        Transform bulletSpawnPosition, DamagableEntitieTypes[] damagableEntitiesArray, bool isFlip)
        {
            var newBullet = NightPool.Spawn(bulletPrefab, bulletSpawnPosition);
            newBullet.transform.localPosition = Vector3.zero;

            newBullet.transform.parent = null;
            newBullet.transform.SetParent(null);
            newBullet.Init(damagableEntitiesArray, shootDirection, bulletSpeed);
            if (isFlip)
                newBullet.transform.Rotate(0,0,180);
        }
    }
}