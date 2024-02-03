using DefaultNamespace;
using Game;
using UnityEngine;

namespace Obstacle
{
    public class TriggerClashComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;
        
        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }
        
        private void OnTriggerEnter(Collider other)
        {
            if(other.TryGetComponent<MoveBallComponent>(out var obstacle))
            {
                _gameModel.GameState.Value = GameState.GameOver;
            }
        }

        
    }
}