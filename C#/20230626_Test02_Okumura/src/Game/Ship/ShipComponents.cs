// Created by FCA22020001@edu.fca.ac.jp (Okumura Naofumi)

// USING SPACE ------------------------------------------------------------- //
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// CODING SPACE ------------------------------------------------------------ //
namespace _20230626_Test02_Okumura.src.Game.Ship
{
    public class ShipComponents
    {
        /// <summary>
        /// 船の名前
        /// </summary>
        public static string Name { get; set; } = "Ship";
        /// <summary>
        /// 船の体力
        /// デフォルト100
        /// </summary>
        public static int Armor { get; set; } = 100;
        /// <summary>
        /// 船の攻撃力
        /// デフォルト15
        /// </summary>
        public static int Damage { get; set; } = 15;
        /// <summary>
        /// 船が生きているかどうか
        /// </summary>
        public static bool Alive = true;
    }
}
