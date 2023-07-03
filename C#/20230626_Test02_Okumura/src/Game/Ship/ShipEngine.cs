// Created by FCA22020001@edu.fca.ac.jp (Okumura Naofumi)

// USING SPACE ------------------------------------------------------------- //
using _20230626_Test02_Okumura.src.Game.Submarine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// CODING SPACE ------------------------------------------------------------ //
namespace _20230626_Test02_Okumura.src.Game.Ship
{
    public class ShipEngine
    {
        private Random rnd = new();

        public ShipComponents ShipComponents = new();

        /// <summary>
        /// 名前の入力をリクエスト
        /// </summary>
        public void RequestName()
        {
            Console.WriteLine("艦船の名前を決定してください：");
            ShipComponents.Name = Console.ReadLine();
        }
        /// <summary>
        /// 攻撃力を指定
        /// </summary>
        public void SetAttackPower()
        {
            ShipComponents.Damage = rnd.Next(15, 50);
        }
        /// <summary>
        /// 生きているかどうかを判定する
        /// </summary>
        public void SetAlive()
        {
            if (ShipComponents.Armor > 0)
            {
                ShipComponents.Alive = true;
            }
            else
            {
                ShipComponents.Alive = false;
            }
        }
        /// <summary>
        /// 攻撃をする
        /// </summary>
        /// <returns>ShipComponents.Damage</returns>
        public int Attack()
        {
            Console.WriteLine("潜水艦を攻撃！");
            return ShipComponents.Damage;
        }
        /// <summary>
        /// 攻撃を受けた場合に残りArmorを計算する
        /// </summary>
        /// <param name="GetDamage"></param>
        public void CalculateHitpoint(int GetDamage)
        {
            ShipComponents.Armor -= GetDamage;
        }
    }
}
