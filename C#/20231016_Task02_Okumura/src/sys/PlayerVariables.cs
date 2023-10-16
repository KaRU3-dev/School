using System;

namespace _20231016_Task02_Okumura.src.sys{
    public class PlayerVariables{
        // PlayerName
        public string Name { get; set; } = "Player";
        // Player coin
        public int Coin { get; set; } = 300;
        // Drop coin amount
        public int DropCoin { get; set; } = 1;
        // Player card number list
        public int[] Card { get; set; } = new int[3];
        // Player coin paste
        public int CoinPaste { get; set; } = 10;
        // Player add card +1
        public bool AddCard { get; set; } = false;
    }
}
