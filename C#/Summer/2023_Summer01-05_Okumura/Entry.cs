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
//    This program was developed by "VScode" and ".NET 7.0".
//    このプログラムは「VScode」と「.NET 7.0」で開発されています。
//    Please pay attention to the program execution environment configuration
//    when executing this program.
//    このプログラムを実行する際には、プログラムの実行環境設定にご注意ください。
//
//    Project:
//        root -
//             ┠ 2023_Summer01-05_Okumura
//                 ┠ Entry.cs
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
            Dog dog = new();
            /// <summary>
            /// Summer 02 -> region Summer 02 Task
            /// </summary>
            MusicPlayer musicPlayer = new();
            /// <summary>
            /// Summer 03 -> region Summer 03 Task
            /// </summary>
            Rectangle rectangle = new();
            /// <summary>
            /// Summer 04 -> region Summer 04 Task
            /// </summary>
            Striker striker = new();


            #region Summer 01 Task
            /* Task 01
                Dogクラスには、以下のインスタンス変数が必要です。
	            - name（string型）: 犬の名前を保持します。
	            - age（int型）: 犬の年齢を保持します。
	            Dogクラスには、以下のメソッドが必要です。
	            - Bark(): メソッドを呼び出すと、「ワンワン!」と出力されます。
	            - GetDescription(): メソッドを呼び出すと、犬の名前と年齢が表示されます
            */
            // dog.Bark();
            // dog.GetDescription();
            #endregion

            #region Summer 02 Task
            /* Task 02
                MusicPlayerクラスには、以下のインスタンス変数が必要です。
	            - songs（List<string>型）: 再生リストとして曲名のリストを保持します。
	            MusicPlayerクラスには、以下のメソッドが必要です。
	            - AddSong(string song): 引数として曲名を受け取り、再生リストに曲を追加します。
	            - Play(): 再生リストに含まれる曲を順番に出力します。
            */
            // musicPlayer.AskMethod();
            // musicPlayer.Play();
            #endregion

            #region Summer 03 Task
            /* Task 03
                Rectangleクラスには、以下のインスタンス変数が必要です。
	            - width（double型）: 長方形の幅を保持します。
	            - height（double型）: 長方形の高さを保持します。
	            Rectangleクラスには、以下のメソッドが必要です。
	            - CalculateArea(): 長方形の面積を計算して返します。
	            - CalculatePerimeter(): 長方形の周囲長を計算して返します。
            */
            // rectangle.RequestAmount();
            #endregion

            #region Summer 04 Task
            /* Task 04
                - 4人対戦ゲームです。
　　            - 6個のサイコロを振って全てなくなってプレイヤーが勝ちとなります。
　　            - サイコロを振って、6の目が出たらそのサイコロを消すことができます。
　　            - サイコロを振って、1の目が出たら他のプレイヤーに押し付けることができます。
            */
            // striker.Ignition();
            #endregion

            #region Summer 05 Task
            /*
                - 4人対戦ゲームです。
　　            - 1~9のタイルがあり、それを全てひっくり返せなくなったらゲーム終了です。
　　            - 各ターンにプレイヤーは、サイコロを2つ振ります。
　　            - 振ったサイコロの目の数字をひっくり返します。
　　            数字は、単体か二つを足した数字どちらか一つひっくり返します。
　　            例：２と３が出たら、２か３、足して５を選択してひっくり返せます。
　　            - この時に、ひっくり返せないプレイヤーが負けとなり、ひっくり返せなくなるまで続けます。
　　            - もしも、全てひっくり返し切ったら、画面に「JACK POD」を表示し、返し切ったプレイヤー一人勝ちとなり、他の三人の負けになります。
            */
            #endregion

        }
    }
}
