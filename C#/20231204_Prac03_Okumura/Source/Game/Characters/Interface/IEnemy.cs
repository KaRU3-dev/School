using System;

namespace _20231204_Prac03_Okumura
{
    public interface IEnemy : IAttackable
    {
        /// <summary>
        /// 名前
        /// </summary>
        /// <value>string</value>
        public string Name { get; set; }
        /// <summary>
        /// 攻撃力
        /// </summary>
        /// <value>integer</value>
        public int AttackPower { get; }
    }
}
