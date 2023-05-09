using System;
using Entities.DamagableTypes;
using UnityEngine;

namespace Entities.Bullets
{
    public class Bullet : MonoBehaviour
    {
        private DamagableEntitieTypes[] _damagableEntitiesArray;

        public void Init(DamagableEntitieTypes[] damagableEntitiesArray)
        {
            _damagableEntitiesArray = damagableEntitiesArray;
        }
        
        public void Move()
        {
            return;
        }

        private void OnCollisionEnter(Collision other)
        {
            throw new NotImplementedException();
        }
    }
}