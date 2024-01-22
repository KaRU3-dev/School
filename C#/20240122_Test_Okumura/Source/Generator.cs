using System;

namespace GameEngine.Support {
    public class Generator {
        public int GenerateRandomNumber(int min, int max) {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
