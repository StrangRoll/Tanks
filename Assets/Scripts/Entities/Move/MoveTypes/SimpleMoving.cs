using UnityEngine;

namespace Entities.Move.MoveTypes
{
    public class SimpleMoving : IMoveType
    {
        private readonly Transform _movingObject;
        private Vector2 _direction;
        
        public SimpleMoving(Transform objectToMove)
        {
            _movingObject = objectToMove;
        }

        public void Move(float speed)
        {
            _movingObject.Translate(_direction * Time.deltaTime * speed);

        }

        public void ChangeDirection(Vector2 newDirection)
        {
            _direction = newDirection;
        }
    }
}