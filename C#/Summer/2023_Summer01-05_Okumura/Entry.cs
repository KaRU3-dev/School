//  -------------------------------------------------------------------------  //
//
//    Created at 2023 / 07 / 17 (yyyy/mm/dd)
//    Created by OkumuraNaofumi (FCA22020001@edu.fca.ac.jp)
//
//    If you use this program, please remove the comment-outs where you run it.
//    このプログラムを使用する場合は、実行する場所のコメントアウトを削除してください。
//    ex) // example.DoSomething();
//              ↓
//           example.DoSomething();
//
//    Project:
//        root -
//             ┠ 2023_Summer01-05_Okumura
//                 ┠ Main.cs
//                 ┠ src
//                    ┠ 2023_Summer01
//                    ┠ 2023_Summer02
//                    ┠ 2023_Summer03
//                    ┠ 2023_Summer04
//                    ┠ 2023_Summer05
//  -------------------------------------------------------------------------  //

// Using
using System;

// Code
namespace _2023_Summer
{
    internal class Entry
    {
        public static void Main()
        {
            /// <summary>
            /// Summer 01 -> region Summer 01 Task
            /// </summary>
            /// <returns>Class dog</returns>
            Dog dog = new();
            /// <summary>
            /// Summer 02 -> region Summer 02 Task
            /// </summary>
            /// <returns></returns>
            MusicPlayer musicPlayer = new();

            Rectangle rectangle = new();


            #region Summer 01 Task
            // dog.Bark();
            // dog.GetDescription();
            #endregion

            #region Summer 02 Task
            // musicPlayer.AskMethod();
            // musicPlayer.ShowSongList();
            #endregion

            #region Summer 03 Task
            // rectangle.RequestAmount();
            #endregion

            #region Summer 04 Task

            #endregion

            #region Summer 05 Task

            #endregion

        }
    }
}
