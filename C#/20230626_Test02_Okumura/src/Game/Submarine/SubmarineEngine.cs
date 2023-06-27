// Created by FCA22020001@edu.fca.ac.jp (Okumura Naofumi)

// USING SPACE ------------------------------------------------------------- //
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// CODING SPACE ------------------------------------------------------------ //
namespace _20230626_Test02_Okumura.src.Game.Submarine
{
    public class SubmarineEngine
    {
        private static Random rnd = new();

        /// <summary>
        /// 名前の入力をリクエスト
        /// </summary>
        public static void RequestName()
        {
            Console.WriteLine("潜水艦の名前を決定してください：");
            SubmarineComponents.Name = Console.ReadLine();
        }
        /// <summary>
        /// 攻撃力を指定
        /// </summary>
        public static void SetAttackPower()
        {
            SubmarineComponents.Damage = rnd.Next(15, 50);
        }
        /// <summary>
        /// 生きているかどうかを判定する
        /// </summary>
        public static void SetAlive()
        {
            if (SubmarineComponents.Armor > 0)
            {
                SubmarineComponents.Alive = true;
            }
            else
            {
                SubmarineComponents.Alive = false;
            }
        }
        /// <summary>
        /// 攻撃をする
        /// </summary>
        /// <returns>SubmarineComponents.Damage</returns>
        public static int Attack()
        {
            Console.WriteLine("艦船を攻撃！");
            return SubmarineComponents.Damage;
        }

        /// <summary>
        /// 攻撃を受けた場合に残りArmorを計算する
        /// </summary>
        /// <param name="GetDamage"></param>
        public static void CalculateHitpoint(int GetDamage)
        {
            SubmarineComponents.Armor = GetDamage;
        }
    }
}
