using UnityEngine;

namespace Game
{
    public class GameStarter : MonoBehaviour
    {
        public GameScene GameScene;

        private void Start()
        {
            var gameModel = new GameModel();
            
            GameScene.MoveBallComponent.Initialize(gameModel, GameScene);
            
            GameScene.SpawnObstacleComponent.Initialize(gameModel, GameScene);
            GameScene.SpeedObstacleComponent.Initialize(gameModel, GameScene);
            
            GameScene.PointsComponent.Initialize(gameModel, GameScene);

            for (int i = 0; i < GameScene.TextPointsComponent.Length; i++)
            {
                GameScene.TextPointsComponent[i].Initialize(gameModel, GameScene);
            }
            
            GameScene.SaveMaxPointsComponent.Initialize(gameModel, GameScene);
            
            GameScene.PopupGameOverComponent.Initialize(gameModel, GameScene);
            GameScene.RestartButtonGameOverComponent.Initialize(gameModel, GameScene);
        }
    }
}