using UnityEngine;
using UnityEngine.AI;

namespace AI
{
    public class EnemyPathFinder : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private NavMeshAgent agent;

        private void Awake()
        {
            agent.updateUpAxis = false;
            agent.updateRotation = false;
        }

        private void Update()
        {
            agent.SetDestination(target.position);
        }
    }
}