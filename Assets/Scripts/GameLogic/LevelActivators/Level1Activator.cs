using Entities;
using NTC.Global.Pool;

namespace GameLogic.LevelActivators
{
    public class Level1Activator : ILevelActivator
    {
        private Player _player;
        
        public Level1Activator(Player player)
        {
            _player = player;
        }
        
        public void ActivateLevel()
        {
            NightPool.Spawn(_player);
        }
    }
}