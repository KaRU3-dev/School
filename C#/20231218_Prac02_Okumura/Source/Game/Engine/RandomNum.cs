using System;

namespace Game.Engine.Gen{
    public class RandomNum{

        private Random rnd = new();

        /// <summary>
        /// ランダムな数字を生成する
        /// </summary>
        /// <returns>Random.Next</returns>
        public int Generate(int min, int max){
            return rnd.Next(min, max);
        }
    }
}
