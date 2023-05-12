using GameLogic;
using UnityEngine;
using Zenject;

namespace Entities.DamagableTypes
{
    public class PlayerHealth : MonoBehaviour, IDamagable
    {
        [Inject] private ScoreCounter scoreCounter;
        
        [SerializeField] private Player player;
            
        public DamagableEntitieTypes DamagableType => DamagableEntitieTypes.Player;
        
        public void TakeDamage()
        {
            player.gameObject.SetActive(false);
            ScoreCounter.SetScore();
            Time.timeScale = 0;
        }
    }
}