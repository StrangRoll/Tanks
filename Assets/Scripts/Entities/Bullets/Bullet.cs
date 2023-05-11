using System;
using Entities.DamagableTypes;
using UnityEngine;

namespace Entities.Bullets
{
    public class Bullet : MonoBehaviour
    {
        private DamagableEntitieTypes[] _damagableEntitiesArray;
        private Vector2 _shootDirection;
        private float _speed;
        private BulletView _bulletView;

        private void Awake()
        {
            _bulletView = new BulletView(transform);
        }

        private void Update()
        {
            transform.Translate(Vector3.up * (_speed * Time.deltaTime));
        }

        public void Init(DamagableEntitieTypes[] damagableEntitiesArray, Vector2 shootDirection, float speed)
        {
            _damagableEntitiesArray = damagableEntitiesArray;
            _shootDirection = shootDirection;
            _speed = speed;
            _bulletView.ChangeDirectionView(shootDirection);
        }
    }
}