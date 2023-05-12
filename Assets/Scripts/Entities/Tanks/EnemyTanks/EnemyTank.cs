using System;
using AI;
using Entities.DamagableTypes;
using Entities.Move.MoveInputs;
using Entities.Move.MoveTypes;
using Entities.Weapon.IWeaponInputs;
using Entities.Weapon.WeaponInfos;
using Entities.Weapon.WeaponTypes;
using Pathfinding;
using Systems;
using UnityEngine;

namespace Entities.Tanks
{
    public class EnemyTank : Tank
    {
        [SerializeField] private DamagableEntitieTypes[] damagableEntities;
        [SerializeField] private float timeToActivate;

        protected override void SetMoveType(Rigidbody2D rigidbodyToMove)
        {
            MoveType = new NullMoveType();
        }

        protected override void SetMoveInput(TimeCounter timeCounter)
        {
            MoveInput = new NullMoveInput();
        }

        protected override void SetWeapon(WeaponInfo weaponInfo, TimeCounter timeCounter)
        {
            Weapon = new Pistol(damagableEntities, transform, weaponInfo, timeCounter);
        }

        protected override void SetWeaponInput(TimeCounter timeCounter)
        {
            WeaponInput = new EnemyWeaponInput(timeToActivate, timeCounter);
        }
    }
}