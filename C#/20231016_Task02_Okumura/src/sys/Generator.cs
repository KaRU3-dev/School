using System;

namespace _20231016_Task02_Okumura.src.sys{
    public class Generator{
        // Random
        private Random random = new Random();

        // Gen card
        public int GenCard(){
            // Gen card
            return random.Next(0, 45);
        }
    }
}
