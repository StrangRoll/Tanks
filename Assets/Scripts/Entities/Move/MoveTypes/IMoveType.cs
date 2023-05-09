using UnityEngine;

namespace Entities.Move.MoveTypes
{
    public interface IMoveType
    {
        public void Move(float speed);
        
        public void ChangeDirection(Vector2 newDirection);
    }
}