using Entities.DamagableTypes;
using Systems;
using Zenject;

namespace Entities.Weapon
{
    public abstract class Weapon
    {
        [Inject] private TimeCounter timeCounter;
        
        protected bool _isReadyToFire;
        
        private float _reloadTime;
        private DamagableEntitieTypes[] _damagableEntitiesArray;

        public Weapon(DamagableEntitieTypes[] damagableEntitiesArray)
        {
            _damagableEntitiesArray = damagableEntitiesArray;
        }

        public void TryShoot()
        {
            if (!_isReadyToFire) return;
            
            Shoot();
            Reload();
        }
        
        public abstract void Shoot();
        
        protected void Reload()
        {
            timeCounter.SetTimer(_reloadTime, () => { _isReadyToFire = true;});
        }
    }
}