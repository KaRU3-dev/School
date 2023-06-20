using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230619_Prac01
{
    /// <summary>
    /// エネミークラス
    /// <para>string Name { get; set; }</para>
    /// <para>int HitPoint { get; set; }</para>
    /// <para>int Damage { get; set; }</para>
    /// </summary>
    public class Enemy
    {
        public string Name { get; set; }
        public int HitPoint { get; set; }
        public int Damage { get; set; }

        public int Attack(int PlayerHp)
        {
            int attackDamage = PlayerHp - Damage;
            Console.WriteLine($"You attack to enemy with {attackDamage}");
            return attackDamage;
        }
    }
}
