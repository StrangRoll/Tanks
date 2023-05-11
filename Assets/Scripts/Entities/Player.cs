using Entities.Tanks.PlayerTanks;
using Systems;
using UnityEngine;

namespace Entities
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerTank leftTank;
        [SerializeField] private PlayerTank rightTank;

        public void Init(Transform leftTankStartPos, Transform rightTankStartPos, TimeCounter timeCounter)
        {
            leftTank.transform.position = leftTankStartPos.position;
            rightTank.transform.position = rightTankStartPos.position;
            leftTank.Init(timeCounter);
            rightTank.Init(timeCounter);
        }
    }
}