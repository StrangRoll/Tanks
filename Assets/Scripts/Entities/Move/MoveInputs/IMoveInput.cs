using UnityEngine;
using UnityEngine.Events;

namespace Entities.Move.MoveInputs
{
    public interface IMoveInput
    {
        public event UnityAction<Vector2> DirectionChanged;
    }
}