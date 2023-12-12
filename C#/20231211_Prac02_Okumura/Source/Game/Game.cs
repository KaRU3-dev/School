using System;

using GameCore.Characters.Player;
using GameCore.Characters.Computer;

namespace GameCore{
    public class Game{

        private Random rnd = new();

        private bool isStart = false;
        private int TargetNumber { get; set; } = 0;

        // それぞれのキャラクターのインスタンスを生成する
        private Player _player = new();
        private Computer _computer = new();

        // ゲームを開始する
        public void Start(){
            isStart = true;
            Console.WriteLine("ゲームを開始します。");
            Console.WriteLine();

            // プレイヤーの数字を設定する
            Player.num1 = rnd.Next(1, 30);
            Player.num2 = rnd.Next(1, 30);
            // コンピュータの数字を設定する
            Computer.num1 = rnd.Next(1, 30);
            Computer.num2 = rnd.Next(1, 30);

            // お題の数字を設定する
            TargetNumber = rnd.Next(0, 55);

            Console.WriteLine($"お題の数字は、{TargetNumber}です。");

            // ゲームループを開始する
            Update();
        }

        // ゲームループ
        public void Update(){
            while(isStart){
                // プレイヤーの計算を実行する
                char _playerSelectedCalculator = _player.RequestCalculator();
                int _playerResult = _player.ExecuteCalculator(_playerSelectedCalculator);

                // コンピュータの計算を実行する
                char _computerSelectedCalculator = _computer.RequestCalculator();
                int _computerResult = _computer.ExecuteCalculator(_computerSelectedCalculator);

                // お題の数字とプレイヤーの計算結果とコンピューターの計算結果を比較する
                if (TargetNumber == _playerResult || TargetNumber == _computerResult){
                    Console.WriteLine("お題の数字と一致しました。");

                    // それぞれの結果のどちらが一致したかを比較する
                    if (TargetNumber == _playerResult && TargetNumber == _computerResult){
                        Console.WriteLine("引き分けです。");
                        Console.WriteLine("ゲームを終了します。");
                        isStart = false;
                    }
                    else if (TargetNumber == _playerResult){
                        Console.WriteLine("プレイヤーの勝利です。");
                        Console.WriteLine("ゲームを終了します。");
                        isStart = false;
                    }
                    else if (TargetNumber == _computerResult){
                        Console.WriteLine("コンピュータの勝利です。");
                        Console.WriteLine("ゲームを終了します。");
                        isStart = false;
                    }

                    // お互いの計算結果を表示する
                    Console.WriteLine($"プレイヤーの計算結果: {_playerResult}");
                    Console.WriteLine($"コンピュータの計算結果: {_computerResult}");

                    Console.WriteLine("ゲームを終了します。");
                    isStart = false;
                }
                // それぞれの結果のどちらが近いかを比較する
                else if (Math.Abs(TargetNumber - _playerResult) < Math.Abs(TargetNumber - _computerResult)){
                    Console.WriteLine("プレイヤーの勝利です。");

                    // お互いの計算結果を表示する
                    Console.WriteLine($"プレイヤーの計算結果: {_playerResult}");
                    Console.WriteLine($"コンピュータの計算結果: {_computerResult}");

                    Console.WriteLine("ゲームを終了します。");
                    isStart = false;
                }
                else if (Math.Abs(TargetNumber - _playerResult) > Math.Abs(TargetNumber - _computerResult)){
                    Console.WriteLine("コンピュータの勝利です。");

                    // お互いの計算結果を表示する
                    Console.WriteLine($"プレイヤーの計算結果: {_playerResult}");
                    Console.WriteLine($"コンピュータの計算結果: {_computerResult}");

                    Console.WriteLine("ゲームを終了します。");
                    isStart = false;
                }
                else{
                    Console.WriteLine("引き分けです。");

                    // お互いの計算結果を表示する
                    Console.WriteLine($"プレイヤーの計算結果: {_playerResult}");
                    Console.WriteLine($"コンピュータの計算結果: {_computerResult}");

                    Console.WriteLine("ゲームを終了します。");
                    isStart = false;
                }

                Console.WriteLine();
                isStart = false;
            }
        }
    }
}
