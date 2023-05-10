using Entities.DamagableTypes;
using Entities.Move.MoveInputs;
using Entities.Move.MoveTypes;
using Entities.Weapon.IWeaponInputs;
using Entities.Weapon.WeaponInfo;
using Entities.Weapon.WeaponTypes;
using InputSystem;
using Systems;
using UnityEngine;

namespace Entities.Tanks.PlayerTanks
{
    public class PlayerTank : Tank
    {
        [SerializeField] private PlayerInputRoot playerInputRoot;
        [SerializeField] private PlayerTankType tankType;
        [SerializeField] private DamagableEntitieTypes[] damagableEntities;

        protected override void SetMoveType()
        {
            MoveType = new SimpleMoving(transform);
        }

        protected override void SetMoveInput()
        {
            MoveInput = new PlayerMoveInput(playerInputRoot, tankType);
        }

        protected override void SetWeapon(WeaponInfo weapon, TimeCounter timeCounter)
        {
            Weapon = new Pistol(damagableEntities, transform, weapon, timeCounter);
        }

        protected override void SetWeaponInput()
        {
            WeaponInput = new PlayerWeaponInput(playerInputRoot, tankType);
        }
    }
}