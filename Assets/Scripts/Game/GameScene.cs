using DefaultNamespace;
using Obstacle;
using Points;
using PopupGameOver;
using SaveGame;
using UnityEngine;

namespace Game
{
    public class GameScene : MonoBehaviour
    {
        public MoveBallComponent MoveBallComponent;

        public Transform[] SpawnPositions;
        public SpawnObstacleComponent SpawnObstacleComponent;
        public SpeedObstacleComponent SpeedObstacleComponent;

        public PointsComponent PointsComponent;
        public TextPointsComponent[] TextPointsComponent;
        public SaveMaxPointsComponent SaveMaxPointsComponent;
        public TextMaxPointsComponent TextMaxPointsComponent;

        public PopupGameOverComponent PopupGameOverComponent;
        public RestartButtonGameOverComponent RestartButtonGameOverComponent;
        public MenuButtonGameOverComponent MenuButtonGameOverComponent;
        public InteractableButtonsGameOverComponent[] InteractableButtonsGameOverComponent;

        public int SpeedBall;
        public float minXLimit;
        public float maxXLimit;
        
        public float StartSpeedObstacle;
        public float MaxSpeedObstacle;
        public float Acceleration;
    }
}