using UnityEngine;

namespace Entities.DamagableTypes
{
    public class DamagableEntitie
    {
        [SerializeField] private DamagableEntitieTypes damagableType;

        public DamagableEntitieTypes DamagableType => damagableType;
    }
}