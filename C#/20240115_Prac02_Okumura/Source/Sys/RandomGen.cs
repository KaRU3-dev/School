using System;

namespace Source.Sys {
    public class RandomGen {

        public int[] ?rndInts;

        public void Generate(int min, int max, int amount) {

            rndInts = new int[amount];

            Random random = new Random();
            for (int i = 0; i < amount; i++) {
                rndInts[i] = random.Next(min, max);
            }
        }

        public int[] GetRndInts() {
            if (rndInts != null) {
                return rndInts;
            } else {
                return null;
            }
        }
    }
}
