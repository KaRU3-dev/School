using System;

using Game.Characters.Interface;

namespace Game.Characters
{
    public struct Enemy : ICharactersBase
    {
        private string name = "";
        private int attackPower = 0;
        private bool isPlayer;

        public string Name
        {
            get { return this.name; }
            set { name = value; }
        }
        public int AttackPower
        {
            get { return this.attackPower; }
        }

        public bool IsPlayer
        {
            get { return this.isPlayer; }
            set { isPlayer = value; }
        }

        /// <summary>
        /// 攻撃
        /// </summary>
        public int Attack()
        {
            return this.attackPower;
        }

        public Enemy(string name, int attackPower, bool isPlayer)
        {
            this.name = name;
            this.attackPower = attackPower;
            this.isPlayer = isPlayer;
        }
    }
}
