using System;
using Game;
using UnityEngine;
using UnityEngine.UI;

namespace PopupGameOver
{
    public class InteractableButtonsGameOverComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private Button _button;
        
        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;

            UpdateInteractable();

            _gameModel.GameState.Changed += OnGameStateChanged;
        }

        private void OnDestroy()
        {
            _gameModel.GameState.Changed += OnGameStateChanged;

        }

        private void OnGameStateChanged()
        {
            UpdateInteractable();
        }

        private void UpdateInteractable()
        {
            if (_gameModel.GameState.Value == GameState.GameOver)
            {
                _button.interactable = true;
            }
            else
            {
                _button.interactable = false;
            }
        }
    }
}