using UnityEngine;

namespace Menu
{
    public abstract class MenuComponent : MonoBehaviour
    {
        public abstract void Initialize(MenuModel menuModel, MenuScene menuScene);
    }
}