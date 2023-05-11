using GameLogic.LevelActivators;
using Udar.SceneManager;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameLogic
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private SceneField levelScene;
        
        private LevelLoader _levelLoader;
        private ILevelActivator _levelActivator;
        private bool _isSceneReady = false;
        private Scene _loadedScene;

        private void Awake()
        {
            _levelActivator = new Level1Activator();
            _levelLoader = new LevelLoader(levelScene, _levelActivator);
            SceneManager.sceneLoaded += OnSceneLoaded;
            _levelLoader.LoadScene();
        }

        public void TryLoadScene()
        {
            if (_isSceneReady)
                SceneManager.SetActiveScene(_loadedScene);
        }

        private void OnSceneLoaded(Scene scene, LoadSceneMode arg1)
        {
            _isSceneReady = true;
            _loadedScene = scene;
        }
    }
}