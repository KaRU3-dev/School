using System;

using _20231120_Prac01_Okumura.User;

namespace _20231120_Prac01_Okumura.Game;

public class Game
{
    private IPlayer player1;
    private IPlayer player2;

    public Game(IPlayer player1, IPlayer player2)
    {
        this.player1 = player1;
        this.player2 = player2;
    }

    public void Play()
    {
        int targetCard1 = GenerateRandomCard();
        int targetCard2 = GenerateRandomCard();
        int targetCard3 = GenerateRandomCard();

        int player1Score = 0;
        int player2Score = 0;

        // Console.WriteLine($"Target cards: {targetCard1}, {targetCard2}, {targetCard3}");

        while (player1Score < 3 && player2Score < 3)
        {
            int player1Guess = player1.Guess();
            int player2Guess = player2.Guess();

            Console.WriteLine($"Player 1 guesses: {player1Guess}");
            EvaluateGuess(player1Guess, targetCard1, targetCard2, targetCard3, ref player1Score);

            Console.WriteLine($"Player 2 guesses: {player2Guess}");
            EvaluateGuess(player2Guess, targetCard1, targetCard2, targetCard3, ref player2Score);
        }

        Console.WriteLine($"Player 1 Score: {player1Score}");
        Console.WriteLine($"Player 2 Score: {player2Score}");

        if (player1Score > player2Score)
        {
            Console.WriteLine("Player 1 wins!");
        }
        else if (player2Score > player1Score)
        {
            Console.WriteLine("Player 2 wins!");
        }
        else
        {
            Console.WriteLine("It's a draw!");
        }
    }

    private void EvaluateGuess(int guess, int target1, int target2, int target3, ref int score)
    {
        if (guess == target1 || guess == target2 || guess == target3)
        {
            Console.WriteLine("Hit!");
            score++;
        }
        else if (guess < target1 || guess < target2 || guess < target3)
        {
            Console.WriteLine("Small");
        }
        else
        {
            Console.WriteLine("Big");
        }
    }

    private int GenerateRandomCard()
    {
        Random random = new Random();
        return random.Next(0, 10);
    }
}
