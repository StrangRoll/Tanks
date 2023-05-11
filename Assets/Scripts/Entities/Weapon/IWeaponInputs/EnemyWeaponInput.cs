using AI;
using Systems;
using UnityEngine;
using UnityEngine.Events;

namespace Entities.Weapon.IWeaponInputs
{
    public class EnemyWeaponInput : IWeaponInput
    {
        public event UnityAction<Vector2> ShootDirectionChanged;
        public event UnityAction ShootStateChanged;
        
        private readonly EnemyPathFinder _pathFinder;

        public EnemyWeaponInput(EnemyPathFinder pathFinder, float activationTime, TimeCounter timeCounter)
        {
            _pathFinder = pathFinder;
            timeCounter.SetTimer(activationTime, ActivateEnemyWeapon);
        }

        public void ActivateEnemyWeapon()
        {
            ShootStateChanged?.Invoke();
        }
    }
}