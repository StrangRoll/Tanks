using GameLogic.LevelActivators;
using Pathfinding;
using UnityEngine;
using Zenject;

namespace AI
{
    public class EnemyPathFinder : MonoBehaviour
    {
        [SerializeField] private AILerp aiLerp;
        [SerializeField] private AIDestinationSetter aiDestinationSetter;
        
        [Inject] private MonobehLevelActivator activator;

        private void Start()
        {
            if (aiLerp.hasPath == false) return;
                
            aiDestinationSetter.target = (aiDestinationSetter.target == activator.RightTank.transform) ? activator.LeftTank.transform : activator.RightTank.transform;
        }
    }
}