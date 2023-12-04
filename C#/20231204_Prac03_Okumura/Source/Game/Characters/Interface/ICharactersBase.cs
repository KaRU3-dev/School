using System;

namespace Game.Characters.Interface
{
    public interface ICharactersBase : IAttackable
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
        public int AttackPower { get;}
        /// <summary>
        /// プレイヤーかどうか
        /// </summary>
        /// <value>bool</value>
        public bool IsPlayer { get; set; }
    }
}
