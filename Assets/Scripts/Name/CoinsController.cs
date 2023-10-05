using System;

namespace Name
{
   public class CoinsController
   {
      private int m_coins = 0;
      public int MainCoins => Load();

      public void SaveCoins(string coins)
      {
         var m_coinsInt = Int16.Parse(coins);
         m_coins = m_coins + m_coinsInt;
         Save();  
      }
      private void Save()
      {
         SaveManager.Save(GlobalConst.Coins, m_coins);
      }

      private int Load()
      {
         var result = SaveManager.LoadInt(GlobalConst.Coins);
         return result;
      }
   }
}
