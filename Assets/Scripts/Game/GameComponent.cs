using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using Game;
using UnityEngine;

public abstract class GameComponent : MonoBehaviour
{
    public abstract void Initialize(GameModel gameModel, GameScene gameScene);
}
