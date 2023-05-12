using NTC.Global.Pool;
using UnityEngine;

namespace Entities.DamagableTypes
{
    public class PlayerHealth : MonoBehaviour, IDamagable
    {
        [SerializeField] private Player player;
            
        public DamagableEntitieTypes DamagableType => DamagableEntitieTypes.Player;
        
        public void TakeDamage()
        {
            player.gameObject.SetActive(false);
        }
    }
}