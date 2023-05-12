using Entities;
using Entities.Tanks;
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
        
        public Tank LeftTank{ get; private set; }
        public Tank RightTank{ get; private set; }
        
        private void Awake()
        {
            var player = Instantiate(playerPrefab);
            player.Init(leftTankStartPos, rightTankStartPos, _timeCounter);
            LeftTank = GameObject.Find("Left").GetComponent<Tank>();
            RightTank = GameObject.Find("Right").GetComponent<Tank>();
        }
    }
}