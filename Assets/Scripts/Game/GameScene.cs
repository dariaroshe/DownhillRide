using DefaultNamespace;
using Obstacle;
using Points;
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
        public TextPointsComponent TextPointsComponent;

        public int SpeedBall;
        public float minXLimit;
        public float maxXLimit;
        
        public float StartSpeedObstacle;
        public float MaxSpeedObstacle;
        public float Acceleration;
    }
}