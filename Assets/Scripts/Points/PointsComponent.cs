using System.Collections;
using Game;
using UnityEngine;

namespace Points
{
    public class PointsComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;
        
        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;

            StartCoroutine(AddPoints());
        }

        private IEnumerator AddPoints()
        {
            var points = _gameModel.Points;
            var gameState = _gameModel.GameState;

            while (true)
            {
                if (gameState.Value == GameState.Playing)
                {
                    points.Value += Time.deltaTime * _gameModel.SpeedObstacle;
                }

                yield return null;
            }
        }
    }
}