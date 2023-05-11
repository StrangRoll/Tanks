using Entities;
using NTC.Global.Pool;
using Systems;
using UnityEngine;
using Zenject;

namespace GameLogic.LevelActivators
{
    public class MonobehLevelActivator : MonoBehaviour
    {
        [Inject] private TimeCounter _timeCounter;
        
        [SerializeField] private Player playerPrefab;
        [SerializeField] private Transform leftTankStartPos;
        [SerializeField] private Transform rightTankStartPos;
        
        private void Awake()
        {
            var player = NightPool.Spawn(playerPrefab);
            player.Init(leftTankStartPos, rightTankStartPos, _timeCounter);
        }
    }
}