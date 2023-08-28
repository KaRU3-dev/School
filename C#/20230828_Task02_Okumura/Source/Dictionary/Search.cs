using System;

namespace _20230828_Task02_Okumura
{
    public class Search : AppEngine
    {

        public string Name = "";

        public void Request()
        {
            Console.WriteLine("検索モードになりました");
            Console.Write("検索する本の名前を入力してください: ");
            Name = Console.ReadLine();

            while (Name == "")
            {
                Console.Write("検索する本の名前を入力してください: ");
                Name = Console.ReadLine();
            }

            //
            Searching(Name);
        }

        private void Searching(string target)
        {
            if (Titles.Contains(target))
            {
                Console.WriteLine($"{target} が見つかりました!");
            }
            else
            {
                Console.WriteLine($"{target} は見つかりませんでした。");
            }
        }
    }
}
