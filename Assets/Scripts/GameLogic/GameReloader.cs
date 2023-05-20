using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

namespace GameLogic
{
    public class GameReloader : MonoBehaviour
    {
        private PlayerInput _playerInput;  
        
        private void Awake()
        {
            _playerInput = new PlayerInput();
            _playerInput.Enable(); 
            _playerInput.Game.ReloadGame.performed += ReloadGame;
            _playerInput.Game.ReturnToMainMenu.performed += ReturnToMainMenu; 
        }

        private void OnDestroy()
        {
            _playerInput.Disable();
        }

        private void ReturnToMainMenu(InputAction.CallbackContext obj)
        {
            SceneManager.LoadScene(0);
            ScoreCounter.Score = 0;
        }

        private void ReloadGame(InputAction.CallbackContext obj)
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1;
            ScoreCounter.Score = 0;
        }
    }
}