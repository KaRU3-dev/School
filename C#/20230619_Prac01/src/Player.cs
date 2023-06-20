using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230619_Prac01
{
    /// <summary>
    /// プレイヤークラス
    /// <para>string Name { get; set; }</para>
    /// <para>int HitPoint { get; set; }</para>
    /// <para>int Damage { get; set; }</para>
    /// </summary>
    public class Player
    {
        public string Name { get; set; } = "Player";
        public int HitPoint { get; set; }
        public int Damage { get; set; }

        public int Attack(int EnemyHp)
        {
            int attackDamage = EnemyHp - Damage;
            Console.WriteLine($"You attack to enemy with {attackDamage}");
            return attackDamage;
        }
    }
}
