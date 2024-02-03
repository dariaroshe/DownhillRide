using DefaultNamespace;
using Game;
using UnityEngine;

namespace Obstacle
{
    public class SpeedObstacleComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;
        
        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;

            _gameModel.SpeedObstacle = _gameScene.StartSpeedObstacle;
        }

        private void Update()
        {
            var gameState = _gameModel.GameState;
            var acceleration = _gameScene.Acceleration;

            if (gameState.Value == GameState.Playing)
            {
                _gameModel.SpeedObstacle = Mathf.Clamp(_gameModel.SpeedObstacle + Time.deltaTime * acceleration, 0,
                    _gameScene.MaxSpeedObstacle);
            }
        }
    }
}