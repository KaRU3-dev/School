namespace _20231120_Prac01_Okumura.User;

using System;

public class Player : IPlayer
{
    public int Guess()
    {
        int guess;
        do
        {
            Console.Write("Enter your guess (0-9): ");
        } while (!int.TryParse(Console.ReadLine(), out guess) || guess < 0 || guess > 9);

        return guess;
    }
}

