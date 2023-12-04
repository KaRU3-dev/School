using System;

using Game.Characters.Interface;
using Game.Characters;

namespace Game
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // インターフェースを実装したクラスのインスタンスを生成
            ICharactersBase enemy = new Enemy(
                name: "Slime",
                attackPower: 10,
                isPlayer: false
            );
            ICharactersBase player = new Player(
                name: "Legend",
                attackPower: 100,
                isPlayer: true
            );

            // 読み取り専用のため、値の変更はできない
            // enemy.AttackPower = 100;
            // player.AttackPower = 80;

            // キャラクターの情報を表示
            Console.WriteLine($"Enemy: {enemy.Name} | {enemy.AttackPower} | IsPlayer: {enemy.IsPlayer}");
            Console.WriteLine($"Player: {player.Name} | {player.AttackPower} | IsPlayer: {player.IsPlayer}");

            // 攻撃
            Console.WriteLine($"Enemy attack: {enemy.Attack()} -> target: {player.Name}");
            Console.WriteLine($"Your attack: {player.Attack()} -> target: {enemy.Name}");

        }
    }
}
