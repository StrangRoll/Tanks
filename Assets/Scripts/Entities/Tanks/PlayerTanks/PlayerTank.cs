using Entities.Move.MoveInputs;
using Entities.Move.MoveTypes;
using InputSystem;
using UnityEngine;

namespace Entities.Tanks.PlayerTanks
{
    public class PlayerTank : Tank
    {
        [SerializeField] private PlayerInputRoot playerInputRoot;
        [SerializeField] private PlayerTankType tankType;

        protected override void SetMoveType()
        {
            MoveType = new SimpleMoving(transform);
        }

        protected override void SetMoveInput()
        {
            MoveInput = new PlayerMoveInput(playerInputRoot, tankType);
        }

        protected override void SetWeapon()
        {
            return;
        }

        protected override void SetWeaponInput()
        {
            throw new System.NotImplementedException();
        }
    }
}