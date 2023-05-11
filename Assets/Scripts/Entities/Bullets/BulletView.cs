using UnityEngine;

namespace Entities.Bullets
{
    public class BulletView
    {
        private readonly Transform _bulletTransform;
        
        public BulletView(Transform bulletTransform)
        {
            _bulletTransform = bulletTransform;
        }

        public void ChangeDirectionView(Vector2 directionView)
        {
            var targetPosition = (Vector2)_bulletTransform.position + directionView;
        
            // Make the turret look at the target position
            _bulletTransform.LookAt(targetPosition, Vector3.back);
        }
    }
}