using UnityEngine;

namespace Entities.Move
{
    public interface IMoveType
    {
        public void Move(Vector3 movingInput, float speed);
    }
}