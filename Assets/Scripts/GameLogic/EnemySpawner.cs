using System.Collections;
using Entities.Tanks;
using GameLogic.LevelActivators;
using NTC.Global.Pool;
using Pathfinding;
using Systems;
using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

namespace GameLogic
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private Tank[] enemyTanksPrefab;
        [SerializeField] private Transform[] spawnPositionsLeft;
        [SerializeField] private Transform[] spawnPositionsRight;
        [SerializeField] private MonobehLevelActivator activator;
        
        [Inject] private TimeCounter _timeCounter;

        private float _count = 1;
        private float _time = 6f;

        private void Start()
        {
            StartCoroutine(Spawner());
        }

        private IEnumerator Spawner()
        {
            yield return new WaitForSeconds(2.5f);
            
            while (true)
            {
                for (int i = 0; i < _count; i++)
                {
                    SpawnNewEnemy();
                }

                _count += .5f;
                yield return new WaitForSeconds(_time);
                _time += .5f;
            }
        }

        private void SpawnNewEnemy()
        {
            var tankIndexLeft = Random.Range(0, enemyTanksPrefab.Length);
            var tankIndexRight = Random.Range(0, enemyTanksPrefab.Length);
            var spawnPositionIndexLeft = Random.Range(0, spawnPositionsLeft.Length);
            var spawnPositionIndexRight = Random.Range(0, spawnPositionsRight.Length);;

            var tankLeft = Instantiate(enemyTanksPrefab[tankIndexLeft], spawnPositionsLeft[spawnPositionIndexLeft].position, Quaternion.identity);
            tankLeft.Init(_timeCounter);
            tankLeft.GetComponent<AIDestinationSetter>().target = activator.LeftTank.transform;
            
            var tankRight = Instantiate(enemyTanksPrefab[tankIndexRight], spawnPositionsRight[spawnPositionIndexRight].position, Quaternion.identity);
            tankRight.Init(_timeCounter);
            tankRight.GetComponent<AIDestinationSetter>().target = activator.RightTank.transform;
        }

    }
}