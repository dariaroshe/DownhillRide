using DefaultNamespace;
using DefaultNamespace.Service;

namespace Game
{
    public class GameModel
    {
        public readonly Field<GameState> GameState = new Field<GameState>();
        public readonly Field<float> Points = new Field<float>();

        public float SpeedObstacle;
    }
}