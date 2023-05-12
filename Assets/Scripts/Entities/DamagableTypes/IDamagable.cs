namespace Entities.DamagableTypes
{
    public interface IDamagable
    {
        public DamagableEntitieTypes DamagableType { get; }
        
        public void TakeDamage();
    }
}