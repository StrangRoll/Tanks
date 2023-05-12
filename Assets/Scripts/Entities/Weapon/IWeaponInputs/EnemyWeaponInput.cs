using Systems;
using UnityEngine;
using UnityEngine.Events;

namespace Entities.Weapon.IWeaponInputs
{
    public class EnemyWeaponInput : IWeaponInput
    {
        public event UnityAction<Vector2> ShootDirectionChanged;
        public event UnityAction ShootStateChanged;
        
        public EnemyWeaponInput(float activationTime, TimeCounter timeCounter)
        {
            timeCounter.SetTimer(activationTime, ActivateEnemyWeapon);
        }

        public void ActivateEnemyWeapon()
        {
            ShootStateChanged?.Invoke();
        }
    }
}