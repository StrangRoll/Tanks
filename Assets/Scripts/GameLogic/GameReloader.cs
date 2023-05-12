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
        }

        private void OnDestroy()
        {
            _playerInput.Disable();
        }

        private void ReloadGame(InputAction.CallbackContext obj)
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
            ScoreCounter.Score = 0;
        }
    }
}