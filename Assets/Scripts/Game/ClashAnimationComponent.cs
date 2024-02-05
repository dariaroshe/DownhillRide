using System;
using UnityEngine;

namespace Game
{
    public class ClashAnimationComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;
        
        private static readonly int Clash = Animator.StringToHash("Clash");
        
        [SerializeField] private Animator _animationClash;
        
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
                _animationClash.SetTrigger(Clash);
            }
        }
    }
}