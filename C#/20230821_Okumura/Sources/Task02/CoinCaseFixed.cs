using System;

namespace _20230821_Okumura
{
    /// <summary>
    /// 問２：
    /// <para>前問の CoinCase クラスに、次の内容を追加しなさい。</para>
    /// <para>総ての硬貨の枚数を取得する、引数なしの GetCount メソッド。</para>
    /// <para>指定した種類の硬貨の総額を取得する、引数のある GetAmount メソッド。</para>
    /// <para>修正した CoinCase クラスを使用して次のプログラムを作成しなさい。</para>
    /// <para>CoinCase クラスのインスタンスを作成する。</para>
    /// <para>種類と枚数を入力し、AddCoins メソッドで硬貨を追加することを 10 回繰り返す。</para>
    /// <para>各硬貨の枚数と金額を表示する。</para>
    /// <para>硬貨の総枚数を表示する。</para>
    /// <para>総額を表示する。</para>
    /// </summary>
    public class CoinCaseFixed
    {
        private int M500yen, M100yen, M50yen, M10yen, M5yen, M1yen;

        public int kind, amount, tax;

        /// <summary>
        /// お金の種類の指定をリクエストする。
        /// </summary>
        public void RequestKindOfMoney()
        {
            Console.WriteLine($"追加する硬貨の種類(数字)を入力してください: \n1. 500 yen\n2. 100 yen\n3. 50 yen\n4. 10 yen\n5. 5 yen\n6. 1 yen\n");

            while (!(int.TryParse(Console.ReadLine(), out kind)))
            {
                Console.WriteLine($"追加する硬貨の種類(数字)を入力してください: \n1. 500 yen\n2. 100 yen\n3. 50 yen\n4. 10 yen\n5. 5 yen\n6. 1 yen\n");
            }
        }
        /// <summary>
        /// 追加するお金の量をリクエストする。
        /// </summary>
        public void RequestMoneyAmount()
        {
            Console.Write($"追加する硬貨の数を入力してください: ");

            while (!(int.TryParse(Console.ReadLine(), out amount)))
            {
                Console.Write($"追加する硬貨の数を入力してください: ");
            }
        }

        /// <summary>
        /// お金を追加する
        /// </summary>
        /// <param name="kind">int</param>
        /// <param name="amount">int</param>
        public void AddCoins(int kind, int amount)
        {
            if (kind == 1)
            {
                M500yen += amount;
            }
            else if (kind == 2)
            {
                M100yen += amount;
            }
            else if (kind == 3)
            {
                M50yen += amount;
            }
            else if (kind == 4)
            {
                M10yen += amount;
            }
            else if (kind == 5)
            {
                M5yen += amount;
            }
            else if (kind == 6)
            {
                M1yen += amount;
            }
            else
            {
                Console.WriteLine($"[ERROR] Something went wrong...\n    Reason: Money kind is wrong!!");
            }
        }

        /// <summary>
        /// 指定されたお金の枚数を返す。
        /// </summary>
        /// <param name="kind">int</param>
        /// <returns>int MoneyAmount</returns>
        public int GetCount()
        {
            int amount = 0;

            for (int i = 1; i < 7; i++)
            {
                if (i == 1)
                {
                    M500yen += amount;
                }
                else if (i == 2)
                {
                    M100yen += amount;
                }
                else if (i == 3)
                {
                    M50yen += amount;
                }
                else if (i == 4)
                {
                    M10yen += amount;
                }
                else if (i == 5)
                {
                    M5yen += amount;
                }
                else if (i == 6)
                {
                    M1yen += amount;
                }
                else
                {
                    Console.WriteLine($"[ERROR] Something went wrong...\n    Reason: Money kind is wrong!!\n    Where: GetCount(); in CoinCase.cs");
                }
            }
            return amount;
        }

        /// <summary>
        /// お金の総額を返す。
        /// </summary>
        /// <returns>int tax</returns>
        public int GetAmount(int kind)
        {
            if (kind == 1)
            {
                return M500yen * 500;
            }
            else if (kind == 2)
            {
                return M100yen * 100;
            }
            else if (kind == 3)
            {
                return M50yen * 50;
            }
            else if (kind == 4)
            {
                return M10yen * 10;
            }
            else if (kind == 5)
            {
                return M5yen * 5;
            }
            else if (kind == 6)
            {
                return M1yen * 1;
            }
            else
            {
                Console.WriteLine($"[ERROR] Can't get money's tax");
                return 0;
            }
        }
        /// <summary>
        /// 指定されたお金の枚数を返す。
        /// </summary>
        /// <param name="kind">int</param>
        /// <returns>int MoneyAmount</returns>
        public int GetCountSelected(int kind)
        {
            if (kind == 1)
            {
                return M500yen;
            }
            else if (kind == 2)
            {
                return M100yen;
            }
            else if (kind == 3)
            {
                return M50yen;
            }
            else if (kind == 4)
            {
                return M10yen;
            }
            else if (kind == 5)
            {
                return M5yen;
            }
            else if (kind == 6)
            {
                return M1yen;
            }
            else
            {
                Console.WriteLine($"[ERROR] Something went wrong...\n    Reason: Money kind is wrong!!\n    Where: GetCount(); in CoinCase.cs");
            }
            return 1;
        }

        public int GetMoneyAmount()
        {
            return M500yen + M100yen + M50yen + M10yen + M5yen + M1yen;
        }

        public int GetTax()
        {
            return (M500yen * 500) + (M100yen * 100) + (M50yen * 50) + (M10yen * 10) + (M5yen * 1) + (M1yen * 1);
        }
    }
}
