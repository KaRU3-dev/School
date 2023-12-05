// .NET Framework
using System;

// Namespace
using Game.Characters;
using Game.Characters.Interfaces;

namespace Game.Main
{
    public class Core
    {
        private bool isStart = false;
        private int card = 0;
        private int turn = 0;
        private int defaultScore = 0;
        private int winScore = 0;

        private Random rnd = new();

        private ICharacters? user;
        private ICharacters? computer;

        public void Start()
        {
            // カードの枚数を指定
            card = 5;
            // ターン数を指定
            turn = card;
            // 初期得点
            defaultScore = 20;
            // 勝利得点
            winScore = 3;

            // Userを作成
            user = new User(
                name: "人間",
                card: card,
                score: defaultScore
            );
            // Computerを作成
            computer = new Computer(
                name: "コンピュータ",
                card: card,
                score: defaultScore
            );

            // それぞれの得点を設定
            user.Score = defaultScore;
            computer.Score = defaultScore;

            // カードを配る
            for (int i = 0; i < card; i++)
            {
                // Userにカードを配る
                user.Cards[i] = rnd.Next(1, 10);
                // Computerにカードを配る
                computer.Cards[i] = rnd.Next(1, 10);
            }

            // ゲーム開始
            isStart = true;
            Console.WriteLine("ゲームを開始します。");
            Loop();
        }

        private void Loop()
        {
            if (!isStart)
            {
                Console.WriteLine("ゲームが開始されていません。");
                return;
            }

            // ゲームループ
            do
            {
                // ターン数が0になったら終了
                if (turn == 0)
                {
                    isStart = false;
                    Console.WriteLine("ゲームを終了します。");
                    Console.WriteLine($"あなたの得点は {user?.Score} です。");
                    Console.WriteLine($"コンピュータの得点は {computer?.Score} です。");
                    if (user?.Score > computer?.Score)
                    {
                        Console.WriteLine("あなたの勝ちです。");
                    }
                    else if (user?.Score < computer?.Score)
                    {
                        Console.WriteLine("コンピュータの勝ちです。");
                    }
                    else
                    {
                        Console.WriteLine("引き分けです。");
                    }
                    return;
                }

                // ターン数を表示
                Console.WriteLine($"現在のターンは {turn} です。");

                // Userに見せるカードを選ばせる
                Console.WriteLine("あなたのカードを選んでください。");
                for (int i = 0; i < card; i++)
                {
                    Console.WriteLine($"[{i + 1}] {user?.Cards[i]}");
                }
                Console.Write("選択: "); // 選択を促す
                int userCard = int.Parse(Console.ReadLine() ?? "0"); // 数字に変換
                userCard--; // 配列の添字に合わせる
                Console.WriteLine($"あなたは {user?.Cards[userCard]} を選びました。");

                // Computerに見せるカードをランダムで選ばせる
                int computerCard = rnd.Next(0, card);
                Console.WriteLine($"コンピュータは {computer?.Cards[computerCard]} を選びました。");

                // カードを比較
                if (user?.Cards[userCard] > computer?.Cards[computerCard])
                {
                    // Userの勝ち
                    Console.WriteLine("あなたの勝ちです。");
                    // Userの得点を加算
                    user.Score += winScore;
                }
                else if (user?.Cards[userCard] < computer?.Cards[computerCard])
                {
                    // Computerの勝ち
                    Console.WriteLine("コンピュータの勝ちです。");
                    // Computerの得点を加算
                    computer.Score += winScore;
                }
                else
                {
                    // 引き分け
                    Console.WriteLine("引き分けです。");
                }

                // 双方の選んだカードを削除
                user.Cards[userCard] = 0;
                computer.Cards[computerCard] = 0;

                // ターン数を減らす
                turn--;

            } while (isStart);
        }
    }
}
