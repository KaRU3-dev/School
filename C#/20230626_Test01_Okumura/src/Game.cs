using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230626_Test01_Okumura.src
{
    public class Game
    {
        private Random rnd = new();

        public void CurrentSituation()
        {
            Console.WriteLine("欧州サッカーのNo.1クラブを決めるヨーロッパチャンピオンカップ戦決勝！\n" +
                "120分経ったがいまだに決着がついていない！\n" +
                "今からPK戦だ！あなたは決めきることができるのか！？");
        }

        public void ShowHowtoInput()
        {
            Console.Write("\n\n");
            Console.WriteLine("あなたは、シューターです。\n" +
                "0: 右  1: 真ん中  2: 左  で蹴ることができます。");
        }

        public void CheckContinueGame()
        {
            if (Variables.Goal == true)
            {
                Variables.InGame = false;
            }
            else
            {
                Variables.InGame = true;
            }
        }
        public void CheckGoal(int Keaper, int Shooter)
        {
            if (Keaper != Shooter)
            {
                // シューターの勝ち
                Console.Write("あなたの勝ちです！！");
                Variables.Goal = true;
            }
            else
            {
                // 止められた！
                Console.WriteLine("止められた！");
            }
        }

        public void RequestKick()
        {
            Console.Write("蹴る方向を決めてください：");
        }
        public void SetPlayerKickAmount()
        {
            Variables.PlayerKickAmount = int.Parse(Console.ReadLine());
        }
        public void SetKickAmount()
        {
            Variables.KickAmount += 1;
        }

        /// <summary>
        /// キーパーのブロックする方向をランダムで生成
        /// キーパーから見て
        /// 0: 左
        /// 1: 真ん中
        /// 2: 右
        /// </summary>
        public void SetKeaperBlockAmount()
        {
            Variables.KeaperBlockAmount = rnd.Next(0, 3);
            Console.WriteLine(Variables.KeaperBlockAmount);
        }
    }
}
