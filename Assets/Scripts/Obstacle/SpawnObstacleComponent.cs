using DefaultNamespace;
using Game;
using UnityEngine;

namespace Obstacle
{
    public class SpawnObstacleComponent : GameComponent
    {
        [SerializeField] private GameObject _obstacle;

        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private float[] _distanceSpawnPeriod;
        private float _distance;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }

        private void Update()
        {
            var gameState = _gameModel.GameState.Value;

            var randomDistanceSpawnPeriod = Random.Range(0, _distanceSpawnPeriod.Length);

            if (gameState != GameState.Playing)
            {
                return;
            }

            if (_distance > _distanceSpawnPeriod[randomDistanceSpawnPeriod])
            {
                var spawnPositions = _gameScene.SpawnPositions;
                var randomIndexSpawnPosition = Random.Range(0, spawnPositions.Length);

                var newObstacle = Instantiate(_obstacle, spawnPositions[randomIndexSpawnPosition].transform.position,
                    Quaternion.identity);

                var obstacleMove = newObstacle.GetComponent<MoveObstacleComponent>();
                var obstacleClashTrigger = newObstacle.GetComponent<TriggerClashComponent>();

                obstacleMove.Initialize(_gameModel, _gameScene);
                obstacleClashTrigger.Initialize(_gameModel, _gameScene);

                _distance = 0f;
            }
            else
            {
                _distance += Time.deltaTime;
            }
        }
    }
}