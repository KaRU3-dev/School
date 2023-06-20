using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _20230605_Prac01
{
    // ステータス情報を管理するクラス
    class Status
    {
        Components Components = new();

        // コンストラクタ
        public Status(string name, Gender gender, Race race)
        {
            Components.Name = name;
            Components.Gender = gender;
            Components.Race = race;

            // ステータスをランダムに生成する
            var rand = new Random();
            Components.HP = rand.Next(18, 56);
            Components.MP = rand.Next(18, 56);
            Components.Attack = rand.Next(5, 31);
            Components.Defense = rand.Next(5, 31);
            Components.Agility = rand.Next(5, 31);

            // 種族修正を適用する
            ApplyRaceModifier();
        }

        // 種族修正を適用する
        private void ApplyRaceModifier()
        {
            switch (Components.Race)
            {
                case Race.Human:
                    Components.HP += 5;
                    Components.MP += 5;
                    Components.Attack += 5;
                    Components.Defense += 5;
                    Components.Agility += 5;
                    break;
                case Race.Elf:
                    Components.MP += 5;
                    Components.Agility += 5;
                    Components.HP = Math.Max(0, Components.HP - 3);
                    Components.Attack = Math.Max(0, Components.Attack - 3);
                    Components.Defense = Math.Max(0, Components.Defense - 3);
                    break;
                case Race.Dwarf:
                    Components.Attack += 8;
                    Components.Defense += 8;
                    Components.MP = Math.Max(0, Components.MP - 10);
                    Components.Agility = Math.Max(0, Components.Agility - 10);
                    break;
                case Race.Hobbit:
                    Components.HP += 8;
                    Components.Agility += 8;
                    Components.Defense = Math.Max(0, Components.Defense - 4);
                    Components.MP = Math.Max(0, Components.MP - 4);
                    break;
            }
        }

        // ステータスを表示する
        public void PrintStatus()
        {
            Console.WriteLine($"Name: {Components.Name}");
            Console.WriteLine($"Gender: {Components.Gender}");
            Console.WriteLine($"Race: {Components.Race}");
            Console.WriteLine($"HP: {Components.HP}");
            Console.WriteLine($"MP: {Components.MP}");
            Console.WriteLine($"Attack: {Components.Attack}");
            Console.WriteLine($"Defense: {Components.Defense}");
            Console.WriteLine($"Agility: {Components.Agility}");
        }
    }
}
