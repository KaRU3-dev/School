/*
 
    Created by Okumura Naofumi (FCA22020001@edu.fca.ac.jp)
 
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _20230619_Class
{
    internal class Program
    {
        // get; set;
        // プロパティと呼ばれる機能を定義するための機能
        // プロパティはクラスの外側からクラスのフィールドにアクセスするための特殊なメソッド

        private string name;

        private string Name
        {
            get { return name; } // プロパティの値を取得するメソッド
            set { name = value; } // プロパティに値を設定するメソッド
        }


        static void Main(string[] args)
        {
            Program name = new Program();

            name.Name = "Aho";

            Console.WriteLine(name.Name);
        }
    }
}
