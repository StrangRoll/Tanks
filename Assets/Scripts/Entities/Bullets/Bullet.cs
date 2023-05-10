using Entities.DamagableTypes;
using UnityEngine;

namespace Entities.Bullets
{
    public class Bullet : MonoBehaviour
    {        
        private DamagableEntitieTypes[] _damagableEntitiesArray;
        private Vector2 _shootDirection;
        private float _speed;

        public void Init(DamagableEntitieTypes[] damagableEntitiesArray, Vector2 shootDirection, float speed)
        {
            _damagableEntitiesArray = damagableEntitiesArray;
            _shootDirection = shootDirection;
            _speed = speed;
        }

        private void Update()
        {
            transform.Translate(_shootDirection * (_speed * Time.deltaTime));
        }
    }
}