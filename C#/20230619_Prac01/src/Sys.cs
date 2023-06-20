using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230619_Prac01
{
    public class Sys
    {
        public Player player = new();
        public Enemy enemy = new();

        private Random random = new Random();

        #region System
        /// <summary>
        /// プログラムの実行
        /// </summary>
        public void Start()
        {
            // Set player status
            SetPlayerName();
            GeneratePlayerStatus();

            // Set enemy status
            SetEnemyName();
            GenerateEnemyStatus();

            // Attack to each other
            AttackToEnemy();
            AttackToPlayer();
        }
        #endregion


        #region Player Void Space
        /// <summary>
        /// プレイヤーの名前をセット
        /// </summary>
        public void SetPlayerName()
        {
            Console.Write("Please enter player's name: ");
            player.Name = Console.ReadLine();
        }
        /// <summary>
        /// プレイヤーのステータスを設定
        /// </summary>
        public void GeneratePlayerStatus()
        {
            player.HitPoint = random.Next(0, 100);
            player.Damage = random.Next(0, 100);
        }
        /// <summary>
        /// プレイヤーの攻撃関数を呼び出し
        /// </summary>
        public void AttackToEnemy()
        {
            enemy.HitPoint = player.Attack(enemy.HitPoint);
        }
        #endregion

        #region Enemy Void Space
        /// <summary>
        /// エネミーの名前をセット
        /// </summary>
        public void SetEnemyName()
        {
            Console.Write("Please enter enemy's name: ");
            enemy.Name = Console.ReadLine();
        }
        /// <summary>
        /// エネミーのステータスを設定
        /// </summary>
        public void GenerateEnemyStatus()
        {
            enemy.HitPoint = random.Next(0, 100);
            enemy.Damage = random.Next(0, 100);
        }
        /// <summary>
        /// エネミーの攻撃関数を呼び出し
        /// </summary>
        public void AttackToPlayer()
        {
            player.HitPoint = enemy.Attack(enemy.HitPoint);
        }
        #endregion
    }
}
