using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230605_Prac01
{

    // 性別を表す列挙体
    public enum Gender
    {
        Male,
        Female
    }

    // 種族を表す列挙体
    public enum Race
    {
        Human,
        Elf,
        Dwarf,
        Hobbit
    }

    public class Components
    {
        // 名前
        public string Name { get; set; }

        // 性別
        public Gender Gender { get; set; }

        // 種族
        public Race Race { get; set; }

        // 体力
        public int HP { get; set; }

        // 魔力
        public int MP { get; set; }

        // 攻撃力
        public int Attack { get; set; }

        // 防御力
        public int Defense { get; set; }

        // 素早さ
        public int Agility { get; set; }
    }
}
