using UnityEngine;

namespace Entities.Move.MoveTypes
{
    public interface IMoveType
    {
        public void Move(Vector3 movingInput, float speed);
    }
}