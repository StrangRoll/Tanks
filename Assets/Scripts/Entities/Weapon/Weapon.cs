using UnityEngine;

namespace Entities.Weapon
{
    public abstract class Weapon
    {
        protected float ReloadTime;
        
        public abstract void Shoot();
        
        protected void Reload()
        {
            
        }

    }
}