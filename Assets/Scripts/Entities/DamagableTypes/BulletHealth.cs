using NTC.Global.Pool;
using UnityEngine;

namespace Entities.DamagableTypes
{
    public class BulletHealth : MonoBehaviour, IDamagable
    {
        public DamagableEntitieTypes DamagableType => DamagableEntitieTypes.Bullet;
        
        public void TakeDamage()
        {
            if (gameObject.activeSelf)
                NightPool.Despawn(gameObject);
        }
    }
}