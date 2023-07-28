using System;

namespace _2023_Summer
{
    public class Dog
    {
        public string name = "Wanko";
        public int age = 8;

        #region Methods
        /// <summary>
        /// When call this function, bark
        /// </summary>
        public void Bark()
        {
            Console.WriteLine("ワンワン!");
        }
        /// <summary>
        /// Show the dog's description
        /// </summary>
        public void GetDescription()
        {
            Console.WriteLine($"Dog descriptions\nName: {name}\nAge: {age}");
        }

        #endregion
    }
}
