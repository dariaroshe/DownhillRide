using DefaultNamespace;
using Game;
using UnityEngine;

namespace Obstacle
{
    public class MoveObstacleComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private GameObject _obstacle;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }

        private void FixedUpdate()
        {
            var obstaclePosition = _obstacle.transform.position;
            
            if (_gameModel.GameState.Value == GameState.Playing)
            {
                var moveY = obstaclePosition.y + _gameModel.SpeedObstacle * Time.deltaTime;
                _obstacle.transform.position = new Vector3(obstaclePosition.x, moveY, obstaclePosition.z);
            }
            Debug.Log(_gameModel.SpeedObstacle);
        }
    }
}