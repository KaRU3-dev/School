using System;

namespace _20230828_Task01_Okumura
{
    public class Sys
    {
        /// <summary>
        /// Show request start message
        /// </summary>
        public void RequestInfo()
        {
            Console.WriteLine("本のタイトルと著者、出版日を入力してください: ");
        }

        /// <summary>
        /// Show book's title is request and return input
        /// </summary>
        public string RequestTitle()
        {
            Console.Write("タイトル: ");
            string input = Console.ReadLine();

            return input;
        }

        /// <summary>
        /// Show book's author is request and return input
        /// </summary>
        public string RequestAuthor()
        {
            Console.Write("著者: ");
            string input = Console.ReadLine();

            return input;
        }

        /// <summary>
        /// Show book's publication year is request and return input
        /// </summary>
        public int RequestPublicationYear()
        {
            Console.Write("出版日: ");
            int input = int.Parse(Console.ReadLine());

            return input;
        }
    }
}
