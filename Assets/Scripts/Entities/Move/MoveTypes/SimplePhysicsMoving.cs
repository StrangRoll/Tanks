using UnityEngine;

namespace Entities.Move.MoveTypes
{
    public class SimplePhysicsMoving : IMoveType
    {
        private readonly Rigidbody2D _movingRigidbody;
        private Vector2 _direction;
        
        public SimplePhysicsMoving(Rigidbody2D rigidbodyToMove)
        {
            _movingRigidbody = rigidbodyToMove;
        }

        public void Move(float speed)
        {
            _movingRigidbody.MovePosition(_movingRigidbody.position + _direction * (Time.deltaTime * speed));
        }

        public void ChangeDirection(Vector2 newDirection)
        {
            _direction = newDirection;
        }
    }
}