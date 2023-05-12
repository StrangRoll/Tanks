using UnityEngine;
using UnityEngine.Events;

namespace Entities.Move.MoveTypes
{
    public class NullMoveType : IMoveType
    {
        public event UnityAction<Vector2> DirectionChanged;
        
        public void Move(float speed)
        {
            return;
        }

        public void ChangeDirection(Vector2 newDirection)
        {
            return;
        }
    }
}