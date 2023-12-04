using System;

namespace _20231204_Prac01_Okumura
{
    public struct EvenNumber
    {
        private int Num;

        public int GetNum()
        {
            return Num;
        }

        public EvenNumber(int num)
        {
            if (num % 2 == 0)
            {
                this.Num = num;
            }
        }
    }
}
