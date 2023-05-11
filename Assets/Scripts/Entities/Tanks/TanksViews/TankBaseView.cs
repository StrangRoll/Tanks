using UnityEngine;

namespace Entities.Tanks.TanksViews
{
    public class TankBaseView
    {
        private Transform _baseTransform;

        public TankBaseView(Sprite baseSprite, SpriteRenderer baseSpriteRenderer)
        {
            baseSpriteRenderer.sprite = baseSprite;
            _baseTransform = baseSpriteRenderer.transform;
        }

        public void ChangeDirectionView(Vector2 directionView)
        {
            if (directionView == Vector2.zero)
                return;     
            
            var targetPosition = (Vector2)_baseTransform.position + directionView;
        
            // Make the turret look at the target position
            _baseTransform.LookAt(targetPosition, Vector3.forward);
        }
    }
}