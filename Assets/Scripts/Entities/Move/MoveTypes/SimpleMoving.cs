using UnityEngine;

namespace Entities.Move.MoveTypes
{
    public class SimpleMoving : IMoveType
    {
        private readonly Transform _movingObject;
        
        public SimpleMoving(Transform objectToMove)
        {
            _movingObject = objectToMove;
        }
        
        public void Move(Vector3 movingInput, float speed)
        {
            _movingObject.Translate(movingInput * Time.deltaTime * speed);
        }
    }
}