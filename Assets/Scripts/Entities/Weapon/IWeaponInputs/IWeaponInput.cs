using UnityEngine;
using UnityEngine.Events;

namespace Entities.Weapon.IWeaponInputs
{
    public interface IWeaponInput
    {
        public event UnityAction<Vector2> ShootDirectionChanged;
        public event UnityAction ShootStateChanged;
    }
}