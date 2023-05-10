using Entities.Bullets;
using UnityEngine;

namespace Entities.Weapon.WeaponInfos
{
    [CreateAssetMenu(fileName = "NewWeaponInfo", menuName = "MyGame/Weapon/WeaponInfo")]
    public class WeaponInfo : ScriptableObject
    {
        [SerializeField] private string weaponName;
        [SerializeField] private float reloadTime;
        [SerializeField] private float bulletSpeed;
        [SerializeField] private Bullet bulletPrefab;
        
        public float ReloadTime => reloadTime;
        public Bullet BulletPrefab => bulletPrefab;
        public float BulletSpeed => bulletSpeed;
    }
}