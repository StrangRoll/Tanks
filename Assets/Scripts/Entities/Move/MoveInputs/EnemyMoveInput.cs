using AI;
using UnityEngine;
using UnityEngine.Events;

namespace Entities.Move.MoveInputs
{
    public class EnemyMoveInput : IMoveInput
    {
        private EnemyPathFinder _pathfinder;
        private Vector2 _oldDirection = Vector2.zero;
        
        public event UnityAction<Vector2> DirectionChanged;

        public EnemyMoveInput(EnemyPathFinder pathfinder)
        {
            _pathfinder = pathfinder;
            Debug.Log(_pathfinder);
            try
            {
                _pathfinder.EnemyDirectionFounded += OnEnemyDirectionFounded;
                Debug.Log("Успешно");
            }
            catch
            {
                Debug.Log("Oh no");
            }
        }
        
        ~EnemyMoveInput()
        {
            _pathfinder.EnemyDirectionFounded -= OnEnemyDirectionFounded;
        }

        private void OnEnemyDirectionFounded(Vector2 direction)
        {
            if (_oldDirection == direction)
                return;
            
            _oldDirection = direction;
            DirectionChanged?.Invoke(direction);
        }
    }
}