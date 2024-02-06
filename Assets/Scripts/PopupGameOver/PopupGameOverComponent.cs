using Game;
using UnityEngine;

namespace PopupGameOver
{
    public class PopupGameOverComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;
        
        private static readonly int Show = Animator.StringToHash("Show");

        [SerializeField] private Animator _animatorPopupGameOver;
        
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
                _animatorPopupGameOver.SetTrigger(Show);
            }
        }
    }
}