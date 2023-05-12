using System.Collections;
using Pathfinding;
using UnityEngine;
using UnityEngine.Events;

namespace AI
{
    [RequireComponent(typeof(Seeker))]
    public class EnemyPathFinder : MonoBehaviour
    {
        [SerializeField] private Transform target;

        private Seeker _seeker;
        private WaitForSeconds _timer;
        private bool _isActive = true;
        private int _i = 0;

        public event UnityAction<Vector2> EnemyDirectionFounded;

        private void Awake()
        {
            _seeker = GetComponent<Seeker>();
            _timer = new WaitForSeconds(1);
        }

        private void Start()
        {
            StartCoroutine(Test());
        }

        private IEnumerator Test()
        {
            while (_isActive)
            {
                yield return _timer;
                _seeker.StartPath(transform.position, target.position, OnPointGetted);
            }
        }

        private void OnPointGetted(Path path)
        {
            var dir = path.vectorPath[_i] - transform.position;

            if (dir.magnitude < .25f)
            {
                dir = (path.vectorPath[_i] - transform.position).normalized;
            }
            else
            {
                _i++;
                dir = (path.vectorPath[_i] - transform.position).normalized;
            }
            
            var direction = GetClosestCardinalDirection(dir);
            EnemyDirectionFounded?.Invoke(direction);
        }

        private static Vector2 GetClosestCardinalDirection(Vector2 input)
        {
            Vector2[] cardinalDirections = { Vector2.up, Vector2.down, Vector2.left, Vector2.right };
            float closestAngle = Mathf.Infinity;
            Vector2 closestDirection = Vector2.zero;

            foreach (Vector2 direction in cardinalDirections)
            {
                float angle = Vector2.Angle(input, direction);
                if (angle < closestAngle)
                {
                    closestAngle = angle;
                    closestDirection = direction;
                }
            }
            
            return closestDirection;
        }
    }
}