using System;

namespace _20231204_Prac03_Okumura
{
    public struct Enemy : IEnemy
    {
        private string name = "";
        private int attackPower = 0;

        public string Name
        {
            get { return this.name; }
            set { name = value; }
        }
        public int AttackPower
        {
            get { return this.attackPower; }
        }

        /// <summary>
        /// 攻撃
        /// </summary>
        public int Attack()
        {
            return this.attackPower;
        }

        public Enemy(string name, int attackPower)
        {
            this.name = name;
            this.attackPower = attackPower;
        }
    }
}
