using GameLogic.LevelActivators;
using Udar.SceneManager;
using UnityEngine.SceneManagement;

namespace GameLogic
{
    public class LevelLoader 
    {
        private readonly SceneField _sceneToLoad;
        private ILevelActivator _levelActivator;
        
        public LevelLoader(SceneField sceneToLoad, ILevelActivator levelActivator)
        {
            _sceneToLoad = sceneToLoad;
            _levelActivator = levelActivator;
        }

        public void LoadScene()
        {
            SceneManager.LoadScene(_sceneToLoad.Name);
        }
    }
}