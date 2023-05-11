using Udar.SceneManager;
using UnityEngine.SceneManagement;

namespace GameLogic
{
    public class LevelLoader 
    {
        private SceneField _sceneToLoad; 
        
        public LevelLoader(SceneField sceneToLoad)
        {
            _sceneToLoad = sceneToLoad;
        }

        public void LoadScene()
        {
            SceneManager.LoadScene(_sceneToLoad.Name);
        }
    }
}