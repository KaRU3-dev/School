using System;
using System.Runtime.CompilerServices;

namespace _20230828_Task02_Okumura
{
    public class AppEngine : Components
    {
        private int status = 0;

        public Search search = new();
        public Add add = new();
        public Delete delete = new();

        public void ARequest()
        {
            // Request start
            if (status == 0)
            {
                Console.WriteLine($"ようこそ!! ここでは、書籍から検索 / 追加 / 削除 / 一覧表示 をすることができます。");
            }
            else
            {
                Console.WriteLine($"おかえりなさい!! ここでは、書籍から検索 / 追加 / 削除 / 一覧表示 をすることができます。");
            }

            // Mode selection
            Console.WriteLine($"モードを選択してください\n0: 検索\n1: 追加\n2: 削除\n3: 一覧の表示\nデフォルトは 検索 です: ");
            string input = Console.ReadLine();

            while (!(int.TryParse(input, out int result)))
            {
                Console.WriteLine($"モードを選択してください\n0: 検索\n1: 追加\n2: 削除\n3: 一覧の表示\nデフォルトは 検索 です: ");
                input = Console.ReadLine();
            }

            Mode = int.Parse(input);
        }

        public bool EndOrContinue()
        {
            Console.Write("続けますか？: ");
            string input = Console.ReadLine();
            while (input == "")
            {
                Console.Write("続けますか？: ");
                input = Console.ReadLine();
            }

            input.ToLower();

            if (input == "y" || input == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ShowAll()
        {
            int range = Titles.Count();

            for (int i = 0; i <= range; i++)
            {
                Console.WriteLine($"{i + 1} Titles: {Titles[i]}");
            }
        }
    }
}
