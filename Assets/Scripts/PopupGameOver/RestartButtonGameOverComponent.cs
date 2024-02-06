using System;
using Game;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace PopupGameOver
{
    public class RestartButtonGameOverComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private Button _restartButton;
        
        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
            
            _restartButton.onClick.AddListener(OnClickButton);
        }

        private void OnDestroy()
        {
            _restartButton.onClick.RemoveListener(OnClickButton);
        }

        private void OnClickButton()
        {
            SceneManager.LoadScene("Scenes/Game");
        }
    }
}