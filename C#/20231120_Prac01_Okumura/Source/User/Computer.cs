namespace _20231120_Prac01_Okumura.User;

using System;
using System.Collections.Generic;

public class Computer : IPlayer
{
    private List<int> chosenNumbers;

    public Computer()
    {
        chosenNumbers = new List<int>();
    }

    public int Guess()
    {
        int guess;
        do
        {
            guess = GenerateRandomNumber();
        } while (chosenNumbers.Contains(guess));

        chosenNumbers.Add(guess);
        return guess;
    }

    private int GenerateRandomNumber()
    {
        Random random = new Random();
        return random.Next(0, 10);
    }
}
