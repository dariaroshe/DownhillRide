using System;
using Game;
using TMPro;
using UnityEngine;

namespace Points
{
    public class TextPointsComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private TextMeshProUGUI _textPoints;
        
        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;

            _gameModel.Points.Changed += OnChangedValue;
        }

        private void OnDestroy()
        {
            _gameModel.Points.Changed -= OnChangedValue;
        }

        private void OnChangedValue()
        {
            var points = _gameModel.Points;

            var pointsToInt = Mathf.RoundToInt(points.Value);

            _textPoints.text = pointsToInt.ToString();
        }
    }
}