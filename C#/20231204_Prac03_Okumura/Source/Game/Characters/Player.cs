using System;

namespace _20231204_Prac03_Okumura
{
    public struct Player : IPlayer
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

        public Player(string name, int attackPower, bool isPlayer)
        {
            this.name = name;
            this.attackPower = attackPower;
            this.isPlayer = isPlayer;
        }
    }
}
