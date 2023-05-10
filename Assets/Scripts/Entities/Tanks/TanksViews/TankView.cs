using Entities.Tanks.TankViewInfos;
using UnityEngine;

namespace Entities.Tanks.TanksViews
{
    public class TankView
    {
        private TankBaseView _tankBaseView;
        private TankWeaponView _tankWeaponView;
        
        public TankView(TankViewInfo tankViewInfo, SpriteRenderer weaponSpriteRenderer, SpriteRenderer baseSpriteRenderer)
        {
            _tankBaseView = new TankBaseView(tankViewInfo.BaseSprite, baseSpriteRenderer);
            _tankWeaponView = new TankWeaponView(tankViewInfo.WeaponSprite, weaponSpriteRenderer);
        }

        public void ChangeMoveDirectionView(Vector2 directionView)
        {
            _tankBaseView.ChangeDirectionView(directionView);
        }

        public void ChangeShootDirectionView(Vector2 directionView)
        {
            _tankWeaponView.ChangeDirectionView(directionView);
        }
    }
}