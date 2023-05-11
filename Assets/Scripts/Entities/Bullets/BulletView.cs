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
        
            Vector3 relative = _bulletTransform.InverseTransformPoint(targetPosition);
            var angle = Mathf.Atan2(relative.x, relative.y)*Mathf.Rad2Deg;
            
            if (directionView.y == 0)
                _bulletTransform.Rotate(0,0, angle + 180);
            else
                _bulletTransform.Rotate(0,0, angle);
            // Make the turret look at the target position
            //_bulletTransform.LookAt(targetPosition, Vector3.back);
        }
    }
}