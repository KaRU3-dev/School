using System;

namespace _20230828_Task02_Okumura
{
    public class Add : AppEngine
    {
        public void Request()
        {
            // Request start
            Console.WriteLine("追加モードになりました");

            // Request book's name
            Titles.Add(RequestBookName());

            // Request book's author
            Authors.Add(RequestBookAuthor());
        }

        private string RequestBookName()
        {
            Console.Write("追加したい本の名前を入力してください: ");
            string input = Console.ReadLine();
            while (input == "")
            {
                Console.Write("追加したい本の名前を入力してください: ");
                input = Console.ReadLine();
            }

            return input;
        }

        private string RequestBookAuthor()
        {
            Console.Write("追加したい本の著者を入力してください: ");
            string input = Console.ReadLine();
            while (input == "")
            {
                Console.Write("追加したい本の著者を入力してください: ");
                input = Console.ReadLine();
            }

            return input;
        }
    }
}
