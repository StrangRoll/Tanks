using UnityEngine;

namespace Entities.DamagableTypes
{
    public class Walls : MonoBehaviour, IDamagable
    {
        DamagableEntitieTypes IDamagable.DamagableType => DamagableEntitieTypes.NotDestroyable;

        public void TakeDamage()
        {
            return;
        }
    }
}