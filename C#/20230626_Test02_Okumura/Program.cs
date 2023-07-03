// Created by FCA22020001@edu.fca.ac.jp (Okumura Naofumi)

// USING SPACE ------------------------------------------------------------- //
using System;

// CODING SPACE ------------------------------------------------------------ //
namespace _20230626_Test02_Okumura
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Game game = new();

            // ゲーム開始
            game.Start();

            // ゲームループ
            game.Update();
        }
    }
}
