using System;
using Game;
using UnityEngine;

namespace SaveGame
{
    public class SaveMaxPointsComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;
        
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
                var points = _gameModel.Points.Value;
                var pointsToInt = Mathf.RoundToInt(points);
                
                var maxPoints = PlayerPrefs.GetInt(Constants.MaxPoints, 0);

                if (pointsToInt > maxPoints)
                {
                    PlayerPrefs.SetInt(Constants.MaxPoints, pointsToInt);
                }
            }
        }
    }
}