using System;
using Game;
using TMPro;
using UnityEngine;

namespace Points
{
    public class TextMaxPointsComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private TextMeshProUGUI _textMaxPoints;
        
        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;

            _gameModel.GameState.Changed += OnGameStateChanged;
        }

        private void OnDestroy()
        {
            _gameModel.GameState.Changed -= OnGameStateChanged;
        }

        private void OnGameStateChanged()
        {
            if (_gameModel.GameState.Value == GameState.GameOver)
            {
                _textMaxPoints.text = PlayerPrefs.GetInt(Constants.MaxPoints).ToString();
            }
        }
    }
}