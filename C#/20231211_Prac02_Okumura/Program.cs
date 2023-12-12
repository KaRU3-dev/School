using System;

namespace Main{
    public class Program{
        public static void Main(string[] args){
            // ゲームを開始する
            GameCore.Game _game = new();

            _game.Start();
        }
    }
}
