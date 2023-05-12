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
        [SerializeField] private MonobehLevelActivator activator;
        
        [Inject] private TimeCounter _timeCounter;

        private int _count = 1;
        private WaitForSeconds _waitForSeconds = new WaitForSeconds(7f);

        private void Start()
        {
            StartCoroutine(Spawner());
        }

        private IEnumerator Spawner()
        {
            yield return new WaitForSeconds(2f);
            
            while (true)
            {
                for (int i = 0; i < _count; i++)
                {
                    SpawnNewEnemy();
                }

                _count++;
                yield return _waitForSeconds;
            }
            
        }

        private void SpawnNewEnemy()
        {
            var tankIndex = Random.Range(0, enemyTanksPrefab.Length);
            var spawnPositionIndex = Random.Range(0, spawnPositionsLeft.Length);

            var tank = NightPool.Spawn(enemyTanksPrefab[tankIndex], spawnPositionsLeft[spawnPositionIndex].position, Quaternion.identity);
            tank.Init(_timeCounter);
            tank.GetComponent<AIDestinationSetter>().target = activator.LeftTank.transform;
        }

    }
}