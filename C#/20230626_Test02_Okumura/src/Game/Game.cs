// Created by FCA22020001@edu.fca.ac.jp (Okumura Naofumi)

// USING SPACE ------------------------------------------------------------- //
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20230626_Test02_Okumura.src.Game;
using _20230626_Test02_Okumura.src.Game.Ship;
using _20230626_Test02_Okumura.src.Game.Submarine;

// CODING SPACE ------------------------------------------------------------ //
namespace _20230626_Test02_Okumura
{
    public class Game
    {
        private ShipEngine ShipEngine = new();
        private SubmarineEngine SubmarineEngine = new();

        private GameVariables GameVariables = new();

        public void Start()
        {
            // スタート
            StartLog();
            // セットインゲーム
            GameVariables.InGame = true;

            // 両方の名前をリクエスト
            ShipEngine.RequestName();
            SubmarineEngine.RequestName();

            // 両方の攻撃力をセット
            ShipEngine.SetAttackPower();
            SubmarineEngine.SetAttackPower();
        }

        public void Update()
        {
            while (GameVariables.InGame)
            {
                if (CheckAlive())
                {
                    // 艦船に潜水艦が攻撃
                    int SubAtk = SubmarineEngine.Attack();
                    ShipEngine.CalculateHitpoint(SubAtk);

                    // 潜水艦に艦船が攻撃
                    int ShipAtk = ShipEngine.Attack();
                    SubmarineEngine.CalculateHitpoint(ShipAtk);

                    // 生きていられるかを判定し、設定
                    SubmarineEngine.SetAlive();
                    ShipEngine.SetAlive();
                }
                else
                {
                    // どちらが勝利したかを判定し、出力
                    CheckResult(ShipEngine.ShipComponents.Alive, SubmarineEngine.SubmarineComponents.Alive);

                    // ゲームを終了
                    GameVariables.InGame = false;
                }
            }
        }

        /// <summary>
        /// ようこそメッセージ
        /// </summary>
        private void StartLog()
        {
            Console.WriteLine("戦闘海域へようこそ！");
            Console.WriteLine("あなたは、潜水艦乗務員で標的の艦船を破壊する必要があります。");
            Console.Write("\n\n");
        }
        /// <summary>
        /// 両方が生きているか確認
        /// </summary>
        /// <returns>bool true/false</returns>
        private bool CheckAlive()
        {
            if (SubmarineEngine.SubmarineComponents.Alive && ShipEngine.ShipComponents.Alive)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 結果を判定し、結果を表示する
        /// </summary>
        /// <param name="Ship">bool</param>
        /// <param name="Sub">bool</param>
        private void CheckResult(bool Ship, bool Sub)
        {
            if (Ship == true && Sub == false)
            {
                Console.WriteLine($"艦船({ShipEngine.ShipComponents.Name})の勝利！");
            }
            else if (Ship == false && Sub == true)
            {
                Console.WriteLine($"潜水艦({SubmarineEngine.SubmarineComponents.Name})の勝利！");
            }
            else if (Ship == true && Sub == true)
            {
                Console.WriteLine("引き分け！");
            }
        }
    }
}
