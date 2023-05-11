using Entities.Tanks.PlayerTanks;
using UnityEngine;

namespace Entities
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerTank leftTank;
        [SerializeField] private PlayerTank rightTank;
    }
}