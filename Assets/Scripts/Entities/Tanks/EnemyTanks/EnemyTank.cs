using AI;
using Entities.DamagableTypes;
using Entities.Move.MoveTypes;
using Entities.Weapon.IWeaponInputs;
using Entities.Weapon.WeaponInfos;
using Entities.Weapon.WeaponTypes;
using Systems;
using UnityEngine;

namespace Entities.Tanks
{
    public class EnemyTank : Tank
    {
        [SerializeField] private DamagableEntitieTypes[] damagableEntities;
        [SerializeField] private EnemyPathFinder pathFinder;
        [SerializeField] private float timeToActivate;

        protected override void SetMoveType(Rigidbody2D rigidbodyToMove)
        {
            MoveType = new SimpleMoving(rigidbodyToMove);
        }

        protected override void SetMoveInput(TimeCounter timeCounter)
        {
            throw new System.NotImplementedException();
        }

        protected override void SetWeapon(WeaponInfo weaponInfo, TimeCounter timeCounter)
        {
            Weapon = new Pistol(damagableEntities, transform, weaponInfo, timeCounter);
        }

        protected override void SetWeaponInput(TimeCounter timeCounter)
        {
            WeaponInput = new EnemyWeaponInput(pathFinder, timeToActivate, timeCounter);
        }
    }
}