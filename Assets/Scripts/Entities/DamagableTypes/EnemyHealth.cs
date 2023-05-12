using GameLogic;
using UnityEngine;
using Zenject;

namespace Entities.DamagableTypes
{
    public class EnemyHealth : MonoBehaviour, IDamagable
    {
        [Inject] private ScoreCounter _scoreCounter;
        
        public DamagableEntitieTypes DamagableType => DamagableEntitieTypes.Enemy;
        
        public void TakeDamage()
        {
            ScoreCounter.Score += 200;
            Destroy(gameObject);
        }
    }
}