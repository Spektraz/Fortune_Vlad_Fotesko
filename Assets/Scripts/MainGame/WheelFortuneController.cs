using System;
using System.Collections.Generic;
using Name;
using UnityEngine;
using Random = UnityEngine.Random;

namespace MainGame
{
    public class WheelFortuneController 
    {
        private WheelFortuneModel m_viewModel = null;
        private CoinsController m_controller = null;
        public WheelFortuneController(WheelFortuneModel viewModel)
        {
            m_viewModel = viewModel;
            Check();
        }
        public void Initialize()
        {
            InitializeButtons();
        }
        private void InitializeButtons()
        {
            m_viewModel.StartWheel.onClick.AddListener(PlayFortune);
        }
        
        private void DisposeButtons()
        {
            m_viewModel.StartWheel.onClick.RemoveAllListeners();
        }
        public void Dispose()
        {
            DisposeButtons();
        }

        private void PlayFortune()
        {
            RandomizerNumbers();
            m_viewModel.AnimatorWheel.SetTrigger(GlobalConst.WheelTrigger);
            Save(m_viewModel.Numbers[10].text);
        }
       
        private void Check()
        {
            m_controller ??= new CoinsController();
            if(m_controller.MainCoins != 0)
                m_viewModel.Coins.text = m_controller.MainCoins.ToString();
            m_viewModel.Coins.text = "0";
        }
        private void Save(string coins)
        {
            m_controller.SaveCoins(coins);
        }
        private void RandomizerNumbers()
        {
            foreach (var var in m_viewModel.Numbers)
            {
                var number =  Random.Range(1, 100);
                var.text = number.ToString();
                var.text = var.text + "000";
            }
        }
    }
}
