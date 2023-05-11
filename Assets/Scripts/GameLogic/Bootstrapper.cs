using Udar.SceneManager;
using UnityEngine;

namespace GameLogic
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private SceneField levelScene;
        
        private LevelLoader _levelLoader;

        private void Awake()
        {
            _levelLoader = new LevelLoader(levelScene);
            _levelLoader.LoadScene();
        }
    }
}