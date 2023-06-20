/*
 
    Created by Okumura: FCA22020001@edu.fca.ac.jp
    Last update:
        Comment language changed to Japanese.
        Create Components.cs
        Try enum, constructor, get; set; and switch-case.
 
 */

using System;
using System.Diagnostics;
using System.Reflection;

namespace _20230605_Prac01
{
    class Program
    {
        static void Main(string[] args)
        {
            // パーティーメンバーのステータスを生成する
            var characters = new[] {
                CreateCharacter("1"),
                CreateCharacter("2"),
                CreateCharacter("3"),
                CreateCharacter("4")
            };

            // パーティーメンバーのステータスを表示する
            for (int i = 0; i < characters.Length; i++)
            {
                Console.WriteLine($"=== Character {i + 1} ===");
                characters[i].PrintStatus();
                Console.WriteLine();
            }
        }

        // ステータスを作成する
        static Status CreateCharacter(string index)
        {
            Console.WriteLine($"=== Input Character {index} ===");

            // 名前を入力する
            string name;
            do
            {
                Console.Write("Name: ");
                name = Console.ReadLine().Trim();
            } while (name == String.Empty);

            // 性別を選択する
            Console.Write("Gender (0: Male, 1: Female): ");
            int genderIndex;
            while (!int.TryParse(Console.ReadLine(), out genderIndex) || genderIndex < 0 || genderIndex > 1)
            {
                Console.Write("Invalid input. Please enter 0 for Male or 1 for Female: ");
            }
            var gender = (Gender)genderIndex;

            // 種族を選択する
            Console.WriteLine("Race (0: Human, 1: Elf, 2: Dwarf, 3: Hobbit):");
            int raceIndex;
            while (!int.TryParse(Console.ReadLine(), out raceIndex) || raceIndex < 0 || raceIndex > 3)
            {
                Console.Write("Invalid input. Please enter a number between 0 and 3: ");
            }
            var race = (Race)raceIndex;

            // ステータスを生成する
            return new Status(name, gender, race);
        }
    }
}