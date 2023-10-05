using System;
using UnityEngine.SceneManagement;

namespace StartMenu
{
    public class StartMenuController
    {
        private StartMenuModel m_viewModel = null;
        public StartMenuController(StartMenuModel viewModel)
        {
            m_viewModel = viewModel;
        }
        public void Initialize()
        {
            InitializeButtons();
        }
        private void InitializeButtons()
        {
            m_viewModel.StartButton.onClick.AddListener(StartGame);
        }
        
        private void DisposeButtons()
        {
            m_viewModel.StartButton.onClick.RemoveListener(StartGame);
        }
        public void Dispose()
        {
            DisposeButtons();
        }
        private void StartGame()
        {
            m_viewModel.AudioSource.enabled = true;
            SceneManager.LoadScene(GlobalConst.SceneMainGame);
        }
    }
}
