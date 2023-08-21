using System;
using System.Runtime.CompilerServices;

namespace _20230821_Okumura
{
    internal class MainProgram
    {
        public static void Main(string[] args)
        {
            #region Task01. CoinCase
            /// <summary>
            /// CoinCaseクラス
            /// <para>RequestKindOfMoney();</para>
            /// <para>RequestMoneyAmount();</para>
            /// <para>AddCoins(int kind, int amount);</para>
            /// <para>GetCount(int kind);</para>
            /// <para>GetAmount();</para>
            /// </summary>
            /// <returns></returns>
            CoinCase coinCase = new();

            // Temporary int variable
            int kind = 0;

            // Request 10 times
            for (int i = 0; i < 10; i++)
            {
                // Request
                coinCase.RequestKindOfMoney();
                coinCase.RequestMoneyAmount();

                // Add
                coinCase.AddCoins(coinCase.kind, coinCase.amount);
            }

            // Show coin's amount
            for (int i = 1; i < 7; i++)
            {
                // Set kind
                kind = i;

                // Show selected coin's amount
                if (i == 1)
                {
                    Console.WriteLine($"500円が {coinCase.GetCount(kind)} 枚あります。");
                }
                else if (i == 2)
                {
                    Console.WriteLine($"100円が {coinCase.GetCount(kind)} 枚あります。");
                }
                else if (i == 3)
                {
                    Console.WriteLine($"50円が {coinCase.GetCount(kind)} 枚あります。");
                }
                else if (i == 4)
                {
                    Console.WriteLine($"10円が {coinCase.GetCount(kind)} 枚あります。");
                }
                else if (i == 5)
                {
                    Console.WriteLine($"5円が {coinCase.GetCount(kind)} 枚あります。");
                }
                else if (i == 6)
                {
                    Console.WriteLine($"1円が {coinCase.GetCount(kind)} 枚あります。");
                }
                else
                {
                    Console.WriteLine($"このコインは存在しません。");
                    break;
                }
            }

            // Show tax
            Console.WriteLine($"硬貨の総額は {coinCase.GetAmount()} 円です。");

            #endregion

            #region Task02. CoinCaseFixed
            /// <summary>
            /// CoinCaseクラス
            /// <para>RequestKindOfMoney();</para>
            /// <para>RequestMoneyAmount();</para>
            /// <para>AddCoins(int kind, int amount);</para>
            /// <para>GetCount(int kind);</para>
            /// <para>GetAmount();</para>
            /// </summary>
            /// <returns></returns>
            CoinCaseFixed coinCaseFixed = new();

            // Temporary int variable
            int kind2 = 0;

            // Request 10 times
            for (int i = 0; i < 10; i++)
            {
                // Request
                coinCaseFixed.RequestKindOfMoney();
                coinCaseFixed.RequestMoneyAmount();

                // Add
                coinCaseFixed.AddCoins(coinCaseFixed.kind, coinCaseFixed.amount);
            }

            // Show coin's amount
            for (int i = 1; i < 7; i++)
            {
                // Set kind
                kind = i;

                // Show selected coin's amount
                if (i == 1)
                {
                    Console.WriteLine($"500円が {coinCaseFixed.GetAmount(kind)} 円({coinCaseFixed.GetCountSelected(kind)}枚) あります。");
                }
                else if (i == 2)
                {
                    Console.WriteLine($"100円が {coinCaseFixed.GetAmount(kind)} 円({coinCaseFixed.GetCountSelected(kind)}枚) あります。");
                }
                else if (i == 3)
                {
                    Console.WriteLine($"50円が {coinCaseFixed.GetAmount(kind)} 円({coinCaseFixed.GetCountSelected(kind)}枚) あります。");
                }
                else if (i == 4)
                {
                    Console.WriteLine($"10円が {coinCaseFixed.GetAmount(kind)} 円({coinCaseFixed.GetCountSelected(kind)}枚) 枚あります。");
                }
                else if (i == 5)
                {
                    Console.WriteLine($"5円が {coinCaseFixed.GetAmount(kind)} 円({coinCaseFixed.GetCountSelected(kind)}枚) 枚あります。");
                }
                else if (i == 6)
                {
                    Console.WriteLine($"1円が {coinCaseFixed.GetAmount(kind)} 円({coinCaseFixed.GetCountSelected(kind)}枚) 枚あります。");
                }
                else
                {
                    Console.WriteLine($"このコインは存在しません。");
                    break;
                }
            }

            // Show how many money
            Console.WriteLine($"硬貨の合計は、{coinCaseFixed.GetMoneyAmount()}枚\n合計金額は、{coinCaseFixed.GetTax()}円です。");
            #endregion
        }
    }
}
