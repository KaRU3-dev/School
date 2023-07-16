using System;

namespace _2023_Summer
{
    public class Dog
    {
        public string name = "Wanko";
        public int age = 8;

        #region Methods

        public void Bark()
        {
            Console.WriteLine("ワンワン!");
        }

        public void GetDescription()
        {
            Console.WriteLine($"Dog descriptions\nName: {name}\nAge: {age}");
        }

        #endregion
    }
}
