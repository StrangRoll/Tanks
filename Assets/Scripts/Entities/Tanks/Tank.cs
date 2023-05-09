using Entities.Move.MoveInputs;
using Entities.Move.MoveTypes;
using UnityEngine;

namespace Entities.Tanks
{
    public abstract class Tank : MonoBehaviour
    {
        [SerializeField] protected float Speed;
    
        protected Weapon.Weapon Weapon;
        protected IMoveType MoveType;
        protected IMoveInput MoveInput;

        public void Move(Vector3 direction)
        {
            MoveType.Move(direction, Speed);
        }
        
        public abstract void Shoot();

        protected abstract void SetMoveType();
        protected abstract void SetMoveInput();
        protected abstract void SetWeapon();
    }
}
