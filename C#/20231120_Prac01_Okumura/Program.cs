using _20231120_Prac01_Okumura.Game;
using _20231120_Prac01_Okumura.User;


class Program
{
    static void Main()
    {
        IPlayer player = new Player();
        IPlayer computer = new Computer();

        Game game = new Game(player, computer);
        game.Play();
    }
}
