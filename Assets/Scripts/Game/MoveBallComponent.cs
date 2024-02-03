using UnityEngine;

namespace Game
{
    public class MoveBallComponent : GameComponent
    {
        private GameModel _gameModel;
        private GameScene _gameScene;

        [SerializeField] private Rigidbody _rigidbody;

        public override void Initialize(GameModel gameModel, GameScene gameScene)
        {
            _gameModel = gameModel;
            _gameScene = gameScene;
        }
        
        private void FixedUpdate()
        {
            //float moveHorizontal = Input.GetAxis("Horizontal");
            
           // Vector3 movement = new Vector3(moveHorizontal, 0f, 0f) * _gameScene.Speed * Time.deltaTime;
            
            //_rigidbody.MovePosition(transform.position + movement);

            if (_gameModel.GameState.Value == GameState.Playing)
            {
                Vector3 currentPosition = transform.position;

                var moveHorizontal = Input.GetAxis("Horizontal");

                var newPositionX = currentPosition.x + moveHorizontal * _gameScene.SpeedBall * Time.deltaTime;

                newPositionX = Mathf.Clamp(newPositionX, _gameScene.minXLimit, _gameScene.maxXLimit);

                transform.position = new Vector3(newPositionX, currentPosition.y, currentPosition.z);
            }
        }

        
    }
}