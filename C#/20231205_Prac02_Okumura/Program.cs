/*
 * Author: @KaRU3-dev
 * Project: 20231205_Prac02_Okumura
 */

// .NET Framework
using System;

// Namespace
using Game.Main;

namespace Game
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // ゲームのコアを作成
            Core core = new();

            // ゲームを開始
            core.Start();
        }
    }
}
