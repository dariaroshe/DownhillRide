using System;
using Game;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace PopupGameOver
{
    public class MenuButtonGameOverComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private Button _menuButton;
        
        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
            
            _menuButton.onClick.AddListener(OnClickButton);
        }

        private void OnDestroy()
        {
            _menuButton.onClick.RemoveListener(OnClickButton);
        }

        private void OnClickButton()
        {
            SceneManager.LoadScene("Scenes/Menu");
        }
    }
}