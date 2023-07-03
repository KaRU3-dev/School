using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230626_Test01_Okumura.src
{
    public class Sys
    {
        private Game Game = new();

        public void Start()
        {
            // 現在の状況をログで出す
            Game.CurrentSituation();
            // 蹴り方を表示する
            Game.ShowHowtoInput();

            // ゲーム中にする
            Variables.InGame = true;

            // ゲームサイクル
            while (Variables.InGame)
            {
                // キック回数が3回以下ならば
                if (Variables.KickAmount <= 3)
                {
                    // シューターの行動
                    Game.RequestKick();
                    Game.SetPlayerKickAmount();
                    Game.SetKickAmount();

                    // キーパーの行動
                    Game.SetKeaperBlockAmount();

                    // 比較
                    Game.CheckGoal(Variables.PlayerKickAmount, Variables.KeaperBlockAmount);

                    // ゲーム続行かどうかを判断する
                    Game.CheckContinueGame();
                }
                else
                {
                    Variables.InGame = false;
                }
            }

            if (Variables.Goal)
            {
                // 勝利を出力
                Console.Write("\n\n");
                Console.WriteLine("あなたの勝利です！おめでとうございます！");
            }
            else
            {
                // 負けを出力
                Console.Write("\n\n");
                Console.WriteLine("キーパーの勝利です！残念。。。");
            }
        }
    }
}
