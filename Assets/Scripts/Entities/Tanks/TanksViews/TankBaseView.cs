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
            
            Vector3 relative = _baseTransform.InverseTransformPoint(targetPosition);
            var angle = Mathf.Atan2(relative.x, relative.y)*Mathf.Rad2Deg;
            _baseTransform.Rotate(0,0, -angle);
            
            // Make the turret look at the target position
            //_baseTransform.LookAt(targetPosition, Vector3.forward);
        }
    }
}