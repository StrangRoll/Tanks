using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class ReturnerToMainMenu : MonoBehaviour
    {
        public void LoadMainMenu()
        {
            SceneManager.LoadScene(0);
        }
    }
}