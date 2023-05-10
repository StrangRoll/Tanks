using UnityEngine;

namespace Entities.Tanks.TankViewInfos
{
    [CreateAssetMenu(fileName = "NewTankViewInfo", menuName = "MyGame/Tank/TankViewInfo")]
    public class TankViewInfo : ScriptableObject
    {
        [SerializeField] private Sprite baseSprite;
        [SerializeField] private Sprite weaponSprite;
        
        public Sprite BaseSprite => baseSprite;
        public Sprite WeaponSprite => weaponSprite;
    }
}