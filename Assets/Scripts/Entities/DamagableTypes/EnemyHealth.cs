using NTC.Global.Pool;
using UnityEngine;

namespace Entities.DamagableTypes
{
    public class EnemyHealth : MonoBehaviour, IDamagable
    {
        public DamagableEntitieTypes DamagableType => DamagableEntitieTypes.Enemy;
        
        public void TakeDamage()
        {
            Destroy(gameObject);
        }
    }
}