using UnityEngine;

namespace Entities.Tanks.TanksViews
{
    public class TankWeaponView
    {
        private Transform _weaponTransform;
        
        public TankWeaponView(Sprite weaponSprite, SpriteRenderer weaponSpriteRenderer)
        {
            weaponSpriteRenderer.sprite = weaponSprite;
            _weaponTransform = weaponSpriteRenderer.transform;
        }

        public void ChangeDirectionView(Vector2 directionView)
        {
            var targetPosition = (Vector2)_weaponTransform.position + directionView;
            
            Vector3 relative = _weaponTransform.InverseTransformPoint(targetPosition);
            var angle = Mathf.Atan2(relative.x, relative.y)*Mathf.Rad2Deg;
            _weaponTransform.Rotate(0,0, -angle + 180);
            // Make the turret look at the target position
            //_weaponTransform.LookAt(targetPosition, Vector3.forward);
        }
    }
}