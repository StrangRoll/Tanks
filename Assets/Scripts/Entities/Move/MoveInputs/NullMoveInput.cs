using UnityEngine;
using UnityEngine.Events;

namespace Entities.Move.MoveInputs
{
    public class NullMoveInput : IMoveInput
    {
        public event UnityAction<Vector2> DirectionChanged;
    }
}