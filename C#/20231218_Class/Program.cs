using System;

namespace _20231218_Class{
    public class Program{
        public static void Main(string[] args){
            // Lambda expression
            Func<int, int, int> add = (x, y) => x + y;

            List<int> list = new List<int>(){1, 2, 3, 4, 5};

            var eventNumber = list.Where(x => x % 2 == 0);

            foreach(var item in eventNumber){
                Console.WriteLine(item);
            }
        }
    }
}
