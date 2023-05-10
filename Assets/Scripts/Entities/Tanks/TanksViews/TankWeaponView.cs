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
        
            // Make the turret look at the target position
            _weaponTransform.LookAt(targetPosition, Vector3.forward);
        }
    }
}