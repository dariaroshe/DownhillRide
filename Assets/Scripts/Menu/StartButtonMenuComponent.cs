using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Menu
{
    public class StartButtonMenuComponent : MenuComponent
    {
        private MenuModel _menuModel;
        private MenuScene _menuScene;

        [SerializeField] private Button _startButton;
        
        public override void Initialize(MenuModel menuModel, MenuScene menuScene)
        {
            _menuModel = menuModel;
            _menuScene = menuScene;
            
            _startButton.onClick.AddListener(OnClickButton);
        }

        private void OnDestroy()
        {
            _startButton.onClick.RemoveListener(OnClickButton);
        }

        private void OnClickButton()
        {
            SceneManager.LoadScene("Scenes/Game");
        }
    }
}